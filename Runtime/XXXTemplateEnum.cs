using System.Linq;
using System.Reflection;
using UnityEngine;

namespace LymeGame.Utils.Template {
	/// <summary>
	/// 更灵活的枚举
	/// </summary>
	public static class XXXTemplateEnum {
		public const string Ignore = "Ignore";
		public const string None = "None";
		public const string Important = "Important";
	}

	/// <summary>
	/// 用例参考
	/// </summary>
	public class XXXTemplateUseExample : MonoBehaviour {
		//如需使用ValueDropdown，请导入odin插件
		// [ValueDropdown(nameof(GetEnumOptions))]
		public string[] Items;

		/// <summary>
		/// 获取所有该枚举内string
		/// </summary>
		private static string[] GetEnumOptions() {
			return typeof(XXXTemplateEnum).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
				.Where(f => f.IsLiteral && !f.IsInitOnly && f.FieldType == typeof(string)).Select(f => (string) f.GetRawConstantValue()).ToArray();
		}
	}
}