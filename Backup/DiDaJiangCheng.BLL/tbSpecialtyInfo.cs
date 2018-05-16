using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using DiDaJiangCheng.Common;
using DiDaJiangCheng.Model;
namespace DiDaJiangCheng.BLL{
	 	//tbSpecialtyInfo
		public partial class tbSpecialtyInfo
	{
   		     
		private readonly DiDaJiangCheng.DAL.tbSpecialtyInfo dal=new DiDaJiangCheng.DAL.tbSpecialtyInfo();
		public tbSpecialtyInfo()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SpecialtyId)
		{
			return dal.Exists(SpecialtyId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(DiDaJiangCheng.Model.tbSpecialtyInfo model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DiDaJiangCheng.Model.tbSpecialtyInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SpecialtyId)
		{
			
			return dal.Delete(SpecialtyId);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string SpecialtyIdlist )
		{
			return dal.DeleteList(SpecialtyIdlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DiDaJiangCheng.Model.tbSpecialtyInfo GetModel(int SpecialtyId)
		{
			
			return dal.GetModel(SpecialtyId);
		}

	

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DiDaJiangCheng.Model.tbSpecialtyInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DiDaJiangCheng.Model.tbSpecialtyInfo> DataTableToList(DataTable dt)
		{
			List<DiDaJiangCheng.Model.tbSpecialtyInfo> modelList = new List<DiDaJiangCheng.Model.tbSpecialtyInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DiDaJiangCheng.Model.tbSpecialtyInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new DiDaJiangCheng.Model.tbSpecialtyInfo();					
													if(dt.Rows[n]["SpecialtyId"].ToString()!="")
				{
					model.SpecialtyId=int.Parse(dt.Rows[n]["SpecialtyId"].ToString());
				}
																																				model.SpecialtyName= dt.Rows[n]["SpecialtyName"].ToString();
																																model.SpecialtyDescription= dt.Rows[n]["SpecialtyDescription"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}