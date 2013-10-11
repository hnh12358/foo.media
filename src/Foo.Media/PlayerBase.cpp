#include "StdAfx.h"
#include "PlayerBase.h"

namespace Foo
{ 
	namespace Media
	{
		PlayerBase::PlayerBase()
		{
			Location = String::Empty;
			m_state = PlayBackState::Stop;
		}

		void PlayerBase::ProcessCommand(MCIERROR result)
		{
			if(result != 0) throw gcnew MediaException(GetErrorInformation(result));
		}

		String^ PlayerBase::GetErrorInformation(MCIERROR errorCode)
		{
			TCHAR buffer[MAXERRORLENGTH];
			if(mciGetErrorString(errorCode,buffer,MAXERRORLENGTH))
						return gcnew String(buffer);
			return "Unknown Error";
		}

		DWORD PlayerBase::GetStatusInformation(DWORD flag)
		{
			MCI_STATUS_PARMS msp;
			msp.dwItem = flag;
			ProcessCommand(mciSendCommand(DeviceId,	MCI_STATUS, MCI_STATUS_ITEM, (DWORD)(LPMCI_STATUS_PARMS)&msp));
			return msp.dwReturn;
		}
		
#pragma region Properties
		
		String^ PlayerBase::Location::get()
		{
			return m_location;
		}

		void PlayerBase::Location::set(String^ value)
		{
			m_location = value;
			OnLocationChanged(EventArgs::Empty);
		}

		PlayBackState PlayerBase::State::get()
		{
			return m_state;
		}

		void PlayerBase::State::set(PlayBackState value)
		{
			m_state = value;
			OnStateChanged(EventArgs::Empty);
		}

		int PlayerBase::Position::get()
		{
			return m_position;
		}

		void PlayerBase::Position::set(int value)
		{
			m_position = value;
			OnPositionChanged(EventArgs::Empty);
			if(m_position == Length && Length != 0)
			{
				OnMediaEnded(EventArgs::Empty);
			}
		}

		int PlayerBase::Length::get()
		{
			return m_length;
		}

		void PlayerBase::Length::set(int value)
		{
			m_length = value;
			OnLengthChanged(EventArgs::Empty);
		}

		bool PlayerBase::IsOpen::get()
		{
			return m_open;
		}

		void PlayerBase::IsOpen::set(bool value)
		{
			m_open = value;
			if(m_open)
				OnMediaOpen(EventArgs::Empty);
			else
				OnMediaClose(EventArgs::Empty);
		}

#pragma endregion

#pragma region EventHelpers

		void PlayerBase::OnPositionChanged(EventArgs^ e)
		{
			try
			{
				PositionChanged(this, e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}

		void PlayerBase::OnLengthChanged(EventArgs^ e)
		{
			try
			{
				LengthChanged(this, e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}


		void PlayerBase::OnStateChanged(EventArgs^ e)
		{
			try
			{
				StateChanged(this, e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}



		void PlayerBase::OnMediaEnded(EventArgs^ e)
		{
			try
			{
				MediaEnded(this,e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}

		void PlayerBase::OnLocationChanged(EventArgs^ e)
		{
			try
			{
				LocationChanged(this,e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}

		void PlayerBase::OnMediaOpen(EventArgs^ e)
		{
			try 
			{
				MediaOpen(this,e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}

		void PlayerBase::OnMediaClose(EventArgs^ e)
		{
			try
			{
				MediaClose(this,e);
			}
			catch(Exception^ ex)
			{
				//do nothing
			}
		}

#pragma endregion
		
	}
}