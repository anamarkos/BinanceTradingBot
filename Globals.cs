using System;


namespace TradingBot
{
	public static class Globals
	{

		//Api Key
		public static string ApiKey { get; set; }

		//Secret Key
		public static string SecretKey { get; set; }

		//Set to true to make a test order. 
		//Console will write trade details of last real trade if test
		public static bool testCase = false;
		internal static double percentageChange;
		internal static double quatityPerTrade;
		internal static string QuoteCurrency;
		internal static string BaseCurrency;
		internal static int TimerInterval;
	}
}
