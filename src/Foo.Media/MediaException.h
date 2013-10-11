using namespace System;

namespace Foo
{
	namespace Media 
	{
		public ref class MediaException : Exception
		{
		public:
			MediaException(String^ message): Exception(message){}
		};
	}
}
