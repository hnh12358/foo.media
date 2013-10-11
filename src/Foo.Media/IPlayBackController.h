namespace Foo
{
	namespace Media 
	{
		public interface class IPlayBackController
		{
			void Play();
			void Pause();
			void Seek(int newPosition);
			void Stop();
		};
	}
}