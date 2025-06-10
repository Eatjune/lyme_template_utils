using System.Collections.Generic;
using UnityEngine;

namespace LymeGame.Utils.Common {
	[CreateAssetMenu(menuName = "LymeGame/Resource/ItemData", fileName = "ItemData")]
	public class ItemData : ScriptableObject {
		[SerializeField]
		private string m_id;

		public string Id {
			get {
				if (!string.IsNullOrEmpty(m_id)) return m_id;
				return name;
			}
		}

		public string DescName;

		[Multiline(5)]
		public string Description;

		public Sprite Icon;

		public ItemComData[] ItemComData;

		/// <summary>
		/// 获取组件数据
		/// </summary>
		public T GetComponent<T>() where T : ItemComData {
			foreach (var itemComData in ItemComData) {
				if (itemComData is T data) {
					return data;
				}
			}

			return null;
		}

		/// <summary>
		/// 获取所有组件数据
		/// </summary>
		public T[] GetComponents<T>() where T : ItemComData {
			var list = new List<T>();
			foreach (var itemComData in ItemComData) {
				if (itemComData is T data) {
					list.Add(data);
				}
			}

			return list.ToArray();
		}

		/// <summary>
		/// 实例化该scriptableObject
		/// </summary>
		public ItemData GetInstance() {
			var obj = Instantiate(this);
			obj.name = this.name;
			var coms = new List<ItemComData>();
			foreach (var itemComData in ItemComData) {
				coms.Add(itemComData.GetInstance(obj));
			}

			obj.ItemComData = coms.ToArray();
			return obj;
		}
	}
}