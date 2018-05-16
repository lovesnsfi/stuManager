using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.DAL
{
	 	//tbSpecialtyInfo
		public partial class tbSpecialtyInfo
	{
   		     
		public bool Exists(int SpecialtyId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbSpecialtyInfo");
			strSql.Append(" where ");
			                                       strSql.Append(" SpecialtyId = @SpecialtyId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@SpecialtyId", SqlDbType.Int,4)
			};
			parameters[0].Value = SpecialtyId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DiDaJiangCheng.Model.tbSpecialtyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbSpecialtyInfo(");			
            strSql.Append("SpecialtyName,SpecialtyDescription");
			strSql.Append(") values (");
            strSql.Append("@SpecialtyName,@SpecialtyDescription");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@SpecialtyName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SpecialtyDescription", SqlDbType.NVarChar,50)             
              
            };
			            
            parameters[0].Value = model.SpecialtyName;                        
            parameters[1].Value = model.SpecialtyDescription;                        
			   
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
			if (obj == null)
			{
				return 0;
			}
			else
			{
				                    
            	return Convert.ToInt32(obj);
                                                                  
			}			   
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DiDaJiangCheng.Model.tbSpecialtyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbSpecialtyInfo set ");
			                                                
            strSql.Append(" SpecialtyName = @SpecialtyName , ");                                    
            strSql.Append(" SpecialtyDescription = @SpecialtyDescription  ");            			
			strSql.Append(" where SpecialtyId=@SpecialtyId ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@SpecialtyId", SqlDbType.Int,4) ,            
                        new SqlParameter("@SpecialtyName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SpecialtyDescription", SqlDbType.NVarChar,50)             
              
            };
						            
            parameters[0].Value = model.SpecialtyId;                        
            parameters[1].Value = model.SpecialtyName;                        
            parameters[2].Value = model.SpecialtyDescription;                        
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SpecialtyId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbSpecialtyInfo ");
			strSql.Append(" where SpecialtyId=@SpecialtyId");
						SqlParameter[] parameters = {
					new SqlParameter("@SpecialtyId", SqlDbType.Int,4)
			};
			parameters[0].Value = SpecialtyId;


			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string SpecialtyIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbSpecialtyInfo ");
			strSql.Append(" where ID in ("+SpecialtyIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
				
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DiDaJiangCheng.Model.tbSpecialtyInfo GetModel(int SpecialtyId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SpecialtyId, SpecialtyName, SpecialtyDescription  ");			
			strSql.Append("  from tbSpecialtyInfo ");
			strSql.Append(" where SpecialtyId=@SpecialtyId");
						SqlParameter[] parameters = {
					new SqlParameter("@SpecialtyId", SqlDbType.Int,4)
			};
			parameters[0].Value = SpecialtyId;

			
			DiDaJiangCheng.Model.tbSpecialtyInfo model=new DiDaJiangCheng.Model.tbSpecialtyInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["SpecialtyId"].ToString()!="")
				{
					model.SpecialtyId=int.Parse(ds.Tables[0].Rows[0]["SpecialtyId"].ToString());
				}
																																				model.SpecialtyName= ds.Tables[0].Rows[0]["SpecialtyName"].ToString();
																																model.SpecialtyDescription= ds.Tables[0].Rows[0]["SpecialtyDescription"].ToString();
																										
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tbSpecialtyInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM tbSpecialtyInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

