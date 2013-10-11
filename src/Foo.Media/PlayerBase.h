#include "PlayBackState.h"
#include "IPlayBackController.h"
#include "MediaVolume.h"
#include "MediaException.h"

using namespace System;
using namespace System::ComponentModel;
using namespace System::Runtime::InteropServices;

namespace Foo
{
	namespace Media 
	{
		public ref class PlayerBase abstract : Component, IPlayBackController
		{
				PlayBackState m_state;
				String^ m_location;
				int m_position;
				int m_length;
				bool m_open;
		protected:
				property MCIDEVICEID DeviceId;
				void ProcessCommand(MCIERROR result);
				DWORD GetStatusInformation(DWORD flag);
				String^ GetErrorInformation(MCIERROR errorCode);
				virtual void OnPositionChanged(EventArgs^ e);
				virtual void OnLengthChanged(EventArgs^ e);
				virtual void OnStateChanged(EventArgs^ e);
				virtual void OnMediaEnded(EventArgs^ e);
				virtual void OnMediaOpen(EventArgs^ e);
				virtual void OnMediaClose(EventArgs^ e);
				virtual void OnLocationChanged(EventArgs^ e);
		public:
				PlayerBase();
				virtual void Open(String^ location) abstract;
				virtual void Close() abstract;
				virtual void Play() abstract;
				virtual void Pause() abstract;
				virtual void Stop() abstract;
				virtual void Seek(int newPosition) abstract;
				[BrowsableAttribute(false)]
				property String^ Location
				{
					virtual String^ get();
				protected:
					virtual void set(String^ value);
				}
				[BrowsableAttribute(false)]
				property PlayBackState State 
				{
					virtual PlayBackState get();
				protected:
					virtual void set(PlayBackState value);
				}
				[BrowsableAttribute(false)]
				property int Position
				{
					virtual int get();
				protected:
					virtual void set(int value);
				}

				[BrowsableAttribute(false)]
				property int Length
				{
					virtual int get();
				protected:
					virtual void set(int value);
				}

				[BrowsableAttribute(false)]
				property bool IsOpen
				{
					virtual bool get();
				protected:
					virtual void set(bool value);
				}

				event EventHandler^ PositionChanged;
				event EventHandler^ LengthChanged;
				event EventHandler^ StateChanged;
				event EventHandler^ MediaEnded;
				event EventHandler^ MediaOpen;
				event EventHandler^ MediaClose;
				event EventHandler^ LocationChanged;
		};
	}
}