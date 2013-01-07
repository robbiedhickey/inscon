namespace Enterprise.DAL.Framework.Cache
{
	public class NullCacheMetrics : ICacheMetrics
	{
		public int GetRetrieves()
		{
			return 0;
		}

		public int GetHits()
		{
			return 0;
		}

		public int GetMisses()
		{
			return 0;
		}

		public int GetPeeks()
		{
			return 0;
		}

		public int GetPuts()
		{
			return 0;
		}

		public int GetRemoves()
		{
			return 0;
		}

		public void Reset()
		{
		}
	}
}
