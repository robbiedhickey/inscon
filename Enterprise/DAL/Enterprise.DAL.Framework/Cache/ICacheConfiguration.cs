namespace Enterprise.DAL.Framework.Cache
{
	public interface ICacheConfiguration
	{
		bool IsSwitchable { get; }
		bool IsInstrumented { get; }
	}
}
