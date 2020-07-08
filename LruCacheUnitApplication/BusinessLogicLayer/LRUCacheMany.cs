using System.Collections.Generic;
using System.Linq;

namespace LruCacheUnitApplication
{
	public class LRUCacheMany
	{
		private int max_space;
		private Dictionary<int, List<string>> cache;
		private List<KeyValuePair<int, List<string>>> order_list;


		public LRUCacheMany(int new_max_space)
		{
			this.max_space = new_max_space;
			this.cache = new Dictionary<int, List<string>>();
			this.order_list = new List<KeyValuePair<int, List<string>>>();
		}


		public List<string> Get(int key)
		{
			if (cache.ContainsKey(key))
			{
				KeyValuePair<int, List<string>> temp_cache_cell = new KeyValuePair<int, List<string>>(key, cache[key]);
				this.order_list.Remove(temp_cache_cell);
				this.order_list.Add(temp_cache_cell);
				return temp_cache_cell.Value;
			}
			return null;
		}


		public List<string> Post(int key, string value)
		{
			if (!cache.ContainsKey(key))
			{
				List<string> new_list = new List<string>();
				new_list.Add(value);
				KeyValuePair<int, List<string>> temp_cache_cell = new KeyValuePair<int, List<string>>(key, new_list);
				order_list.Add(temp_cache_cell);
				cache[key] = new_list;
				if (order_list.Count == max_space)
				{
					KeyValuePair<int, List<string>> to_delete = order_list[0];
					cache.Remove(to_delete.Key);
					order_list.Remove(to_delete);
				}
			}
			else
			{
				KeyValuePair<int, List<string>> temp_cache_cell = new KeyValuePair<int, List<string>>(key, cache[key]);
				List<string> update_list = temp_cache_cell.Value;
				if (!update_list.Contains(value))
				{
					update_list.Add(value);
					cache[key] = update_list;
				}

				order_list.Remove(temp_cache_cell);
				order_list.Add(new KeyValuePair<int, List<string>>(key, update_list));
			}

			return cache[key];
		}


		public bool Delete(int key)
		{
			if (!cache.ContainsKey(key))
			{
				return true;
			}
			KeyValuePair<int, List<string>> to_delete = new KeyValuePair<int, List<string>>(key, cache[key]);
			return (order_list.Remove(to_delete) && cache.Remove(key));
		}


		public bool Delete(string value)
		{
			KeyValuePair<int, List<string>> to_delete = order_list.FirstOrDefault(x => x.Value.Any(y => y.Equals(value)));
			if (to_delete.Equals(default(KeyValuePair<int, List<string>>)))
			{
				return true;
			}

			order_list.Remove(to_delete);
			to_delete.Value.Remove(value);

			if (to_delete.Value.Count > 0)
			{
				order_list.Add(to_delete);
				cache[to_delete.Key] = to_delete.Value;
				return true;
			}

			return cache.Remove(to_delete.Key);
		}
	}
}
