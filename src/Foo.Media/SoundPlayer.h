#pragma once
#include "PlayerBase.h"

using namespace System;
using namespace System::Windows::Forms;
using namespace System::ComponentModel;

namespace Foo
{
	namespace Media 
	{
		public ref class SoundPlayer : PlayerBase
		{
			Timer^ m_timer;
			array<String^>^ supportedExtensions;
		protected:
			void UpdatePosition(Object^ sender, EventArgs^ e);
		public:
			SoundPlayer();
			virtual void Open(String^ location) override;
			virtual void Close() override;
			virtual void Play() override;
			virtual void Pause() override;
			virtual void Stop() override;
			virtual void Seek(int newPosition) override;
			virtual void OnMediaEnded(EventArgs^ e) override;
			virtual void OnStateChanged(EventArgs^ e) override;
		};
	}
}
