using System.Collections.Generic;
using System.Linq;

namespace LruCacheUnitApplication
{
	public class LRUCacheSimple
	{
		private int max_space;
		private Dictionary<int, string> cache;
		private List<KeyValuePair<int, string>> order_list;


		public LRUCacheSimple(int new_max_space)
		{
			this.max_space = new_max_space;
			this.cache = new Dictionary<int, string>();
			this.order_list = new List<KeyValuePair<int, string>>();
		}


		public string Get(int key)
		{
			if (cache.ContainsKey(key))
			{
				KeyValuePair<int, string> temp_cache_cell = new KeyValuePair<int, string>(key, cache[key]);
				this.order_list.Remove(temp_cache_cell);
				this.order_list.Add(temp_cache_cell);
				return temp_cache_cell.Value;
			}
			return null;
		}


		public string Add(int key, string value)
		{
			if (!cache.ContainsKey(key))
				Post();
			else
				Put(key);

			cache[key] = value;
			this.order_list.Add(new KeyValuePair<int, string>(key, value));
			return cache[key];
		}


		public bool Delete(int key)
		{
			if (!cache.ContainsKey(key))
			{
				return true;
			}
			KeyValuePair<int, string> to_delete = new KeyValuePair<int, string>(key, cache[key]);
			return (order_list.Remove(to_delete) && cache.Remove(key));
		}


		public bool Delete(string value)
		{
			KeyValuePair<int, string> to_delete = order_list.FirstOrDefault(x => x.Value.Equals(value));
			if (to_delete.Equals(default(KeyValuePair<int, string>)))
			{
				return true;
			}
			return (order_list.Remove(to_delete) && cache.Remove(to_delete.Key));
		}



		private void Post()
		{
			if (order_list.Count == max_space)
			{
				KeyValuePair<int, string> to_delete = order_list[0];
				cache.Remove(to_delete.Key);
				order_list.Remove(to_delete);
			}
		}


		private void Put(int key)
		{
			KeyValuePair<int, string> to_delete = new KeyValuePair<int, string>(key, cache[key]);
			order_list.Remove(to_delete);
		}
	}
}
