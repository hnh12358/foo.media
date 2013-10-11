#include "StdAfx.h"
#include "SoundPlayer.h"

using namespace System::IO;
using namespace System::Runtime::InteropServices;
using namespace System::Windows::Forms;

namespace Foo
{ 
	namespace Media
	{

		SoundPlayer::SoundPlayer() : PlayerBase()
		{
			m_timer = gcnew System::Windows::Forms::Timer();
			m_timer->Interval = 1000;
			m_timer->Tick += gcnew EventHandler(this,&SoundPlayer::UpdatePosition);	
			supportedExtensions = gcnew array<String^>{".mp3",".wav",".wma"};
		}//>

		void SoundPlayer::Open(String^ location)
		{	
			String^ extension = Path::GetExtension(location->ToLower());
			if(location != nullptr)
			{
				if(location != String::Empty ) 
				{
					if(Array::IndexOf(supportedExtensions,extension)!=-1)
					{
						if(System::IO::File::Exists(location))
						{
							if(IsOpen) Close();
							MCI_OPEN_PARMS mop;
							IntPtr p = Marshal::StringToHGlobalAuto(location);
							TCHAR* path = static_cast<TCHAR*>(p.ToPointer());
							mop.lpstrElementName = path;
							ProcessCommand(mciSendCommand(NULL, MCI_OPEN, MCI_OPEN_ELEMENT, (DWORD)(LPVOID)&mop));
							Marshal::FreeHGlobal(p);
							DeviceId = mop.wDeviceID;
							IsOpen = true;
							Location = location;
							Length = GetStatusInformation(MCI_STATUS_LENGTH);
							Position = 0;
						}
						else throw gcnew FileNotFoundException("The file " + location + " doesn't exists",location);
					}
					else throw gcnew NotSupportedException("The extension " + extension + " isn't no supported");
				}
				else throw gcnew ArgumentException("The location can't be empty","location");
			}
			else throw gcnew ArgumentException("The location can't be null","location");
		}//>

		void SoundPlayer::Close()
		{
			if(IsOpen)
			{
				Stop();
				MCI_GENERIC_PARMS mcp;
				ProcessCommand(mciSendCommand(DeviceId,MCI_CLOSE,NULL,(DWORD)(LPVOID)&mcp));
				IsOpen = false;
			}
		}//>

		void SoundPlayer::Play()
		{
			if(IsOpen)
				if(State != PlayBackState::Play )
				{
					MCI_PLAY_PARMS mpp;
					mpp.dwFrom = Position;
					ProcessCommand(mciSendCommand(DeviceId,MCI_PLAY,MCI_FROM,(DWORD)(LPVOID)&mpp));
					State = PlayBackState::Play;
				}
		}//>

		void SoundPlayer::Pause()
		{
			if (IsOpen)
				if(State == PlayBackState::Play)
				{
					MCI_GENERIC_PARMS mgp;
					ProcessCommand(mciSendCommand(DeviceId,MCI_PAUSE,NULL,(DWORD)(LPVOID)&mgp));
					State = PlayBackState::Pause;
				}
		}//>

		void SoundPlayer::Stop()
		{
			if (IsOpen)
				if(State == PlayBackState::Play || State == PlayBackState::Pause)
				{
					MCI_GENERIC_PARMS mgp;
					ProcessCommand(mciSendCommand(1,MCI_STOP,NULL,(DWORD)(LPVOID)&mgp));
					State = PlayBackState::Stop;
					Position = 0;
				}
		}//>

		void SoundPlayer::Seek(int newPosition)
		{
			if(IsOpen)
			{
				if(newPosition < 0 && newPosition > Length)
					throw gcnew ArgumentException("The new position must be between 0 and the length of the file","newPosition");
				PlayBackState cacheState = State;
				State = PlayBackState::Seek;
				Position = newPosition;
				if(cacheState == PlayBackState::Play) Play();
			}
		}//>

		void SoundPlayer::UpdatePosition(Object^ sender, EventArgs^ e)
		{
			Position = GetStatusInformation(MCI_STATUS_POSITION);
		}//>

		void SoundPlayer::OnMediaEnded(EventArgs^ e)
		{
			PlayerBase::OnMediaEnded(e);
			Stop();
		}//>

		void SoundPlayer::OnStateChanged(EventArgs^ e)
		{
			PlayerBase::OnStateChanged(e);
			switch(State)
			{
			case PlayBackState::Play:
				m_timer->Start();
				break;
			default:
				m_timer->Stop();
				break;
			}
		}//>
	}
}