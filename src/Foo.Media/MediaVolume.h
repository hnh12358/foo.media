namespace Foo
{
	namespace Media
	{
		public value class MediaVolume
		{
			int m_leftChannel;
			int m_rightChannel;

		public:
			MediaVolume(int value)
			{
				m_leftChannel = value;
				m_rightChannel = value;
			}

			MediaVolume(int left,int right)
			{
				m_leftChannel = left;
				m_rightChannel = right;
			}

			property int LeftChannel
			{
				int get(){ return m_leftChannel;}
			}

			property int RightChannel
			{
				int get(){ return m_rightChannel;}
			}
		};
	}
}
