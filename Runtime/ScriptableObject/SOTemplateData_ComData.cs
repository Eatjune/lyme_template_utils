using UnityEngine;

[CreateAssetMenu(menuName = "LymeGame/SOData/SOTemplateData_ComData", fileName = "SOTemplateData_ComData")]
public class SOTemplateData_ComData : ScriptableObject {
	[SerializeField]
	private string m_id;

	public string Id {
		get {
			if (!string.IsNullOrEmpty(m_id)) return m_id;
			return name;
		}
	}

	public string DescName;
	public string Description;

	protected SOTemplateData SOTemplateData;

	/// <summary>
	/// 实例化该scriptableObject
	/// </summary>
	/// <param name="data">父data</param>
	public SOTemplateData_ComData GetInstance(SOTemplateData data) {
		var obj = Instantiate(this);
		obj.name = this.name;
		obj.SOTemplateData = data;
		return obj;
	}
}