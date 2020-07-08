namespace LruCacheUnitApplication
{
	class Program
	{
		private static LRUCacheMany lruCacheMany = new LRUCacheMany(2);
		private static LRUCacheSimple lruCacheSimple = new LRUCacheSimple(2);


		static void Main(string[] args)
		{

			var one = lruCacheMany.put(1, "ccs");
			var two = lruCacheMany.put(1, "vvvs");
			var three = lruCacheMany.put(1, "bgg");

			var four = lruCacheMany.put(2, "kostya");
			var five = lruCacheMany.put(2, "csaca");
			var six = lruCacheMany.put(2, "btrbtrb");

			var seven = lruCacheMany.put(3, "cccc");
			var eight = lruCacheMany.put(3, "ththr");
			var nine = lruCacheMany.put(3, "bgbgbfgbfgbg");

			bool rem = lruCacheMany.remove("bgbgbfgbfgbg");
			var res = lruCacheMany.get(1);
		}
	}
}
