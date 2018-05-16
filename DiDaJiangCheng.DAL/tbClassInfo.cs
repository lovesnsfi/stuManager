using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.DAL
{
	 	//tbClassInfo
		public partial class tbClassInfo
	{
   		     
		public bool Exists(int ClassId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbClassInfo");
			strSql.Append(" where ");
			                                       strSql.Append(" ClassId = @ClassId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@ClassId", SqlDbType.Int,4)
			};
			parameters[0].Value = ClassId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DiDaJiangCheng.Model.tbClassInfo model)
		{
            
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbClassInfo(");			
            strSql.Append("ClassName,SpecialtyId,classroomId,eductionalSystem,enterTime,Marks");
			strSql.Append(") values (");
            strSql.Append("@ClassName,@SpecialtyId,@classroomId,@eductionalSystem,@enterTime,@Marks");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@ClassName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SpecialtyId", SqlDbType.Int,4) ,            
                        new SqlParameter("@classroomId", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@eductionalSystem", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@enterTime", SqlDbType.Date,3) ,            
                        new SqlParameter("@Marks", SqlDbType.NVarChar,-1)             
              
            };
			            
            parameters[0].Value = model.ClassName;                        
            parameters[1].Value = model.SpecialtyId;                        
            parameters[2].Value = model.classroomId;                        
            parameters[3].Value = model.eductionalSystem;                        
            parameters[4].Value = model.enterTime;                        
            parameters[5].Value = model.Marks;                        
			   
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
		public bool Update(DiDaJiangCheng.Model.tbClassInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbClassInfo set ");
			                                                
            strSql.Append(" ClassName = @ClassName , ");                                    
            strSql.Append(" SpecialtyId = @SpecialtyId , ");                                    
            strSql.Append(" classroomId = @classroomId , ");                                    
            strSql.Append(" eductionalSystem = @eductionalSystem , ");                                    
            strSql.Append(" enterTime = @enterTime , ");                                    
            strSql.Append(" Marks = @Marks  ");            			
			strSql.Append(" where ClassId=@ClassId ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@ClassId", SqlDbType.Int,4) ,            
                        new SqlParameter("@ClassName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@SpecialtyId", SqlDbType.Int,4) ,            
                        new SqlParameter("@classroomId", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@eductionalSystem", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@enterTime", SqlDbType.Date,3) ,            
                        new SqlParameter("@Marks", SqlDbType.NVarChar,-1)             
              
            };
						            
            parameters[0].Value = model.ClassId;                        
            parameters[1].Value = model.ClassName;                        
            parameters[2].Value = model.SpecialtyId;                        
            parameters[3].Value = model.classroomId;                        
            parameters[4].Value = model.eductionalSystem;                        
            parameters[5].Value = model.enterTime;                        
            parameters[6].Value = model.Marks;                        
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
		public bool Delete(int ClassId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbClassInfo ");
			strSql.Append(" where ClassId=@ClassId");
						SqlParameter[] parameters = {
					new SqlParameter("@ClassId", SqlDbType.Int,4)
			};
			parameters[0].Value = ClassId;


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
		public bool DeleteList(string ClassIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbClassInfo ");
			strSql.Append(" where ID in ("+ClassIdlist + ")  ");
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
		public DiDaJiangCheng.Model.tbClassInfo GetModel(int ClassId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ClassId, ClassName, SpecialtyId, classroomId, eductionalSystem, enterTime, Marks  ");			
			strSql.Append("  from tbClassInfo ");
			strSql.Append(" where ClassId=@ClassId");
						SqlParameter[] parameters = {
					new SqlParameter("@ClassId", SqlDbType.Int,4)
			};
			parameters[0].Value = ClassId;

			
			DiDaJiangCheng.Model.tbClassInfo model=new DiDaJiangCheng.Model.tbClassInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["ClassId"].ToString()!="")
				{
					model.ClassId=int.Parse(ds.Tables[0].Rows[0]["ClassId"].ToString());
				}
																																				model.ClassName= ds.Tables[0].Rows[0]["ClassName"].ToString();
																												if(ds.Tables[0].Rows[0]["SpecialtyId"].ToString()!="")
				{
					model.SpecialtyId=int.Parse(ds.Tables[0].Rows[0]["SpecialtyId"].ToString());
				}
																																				model.classroomId= ds.Tables[0].Rows[0]["classroomId"].ToString();
																																model.eductionalSystem= ds.Tables[0].Rows[0]["eductionalSystem"].ToString();
																												if(ds.Tables[0].Rows[0]["enterTime"].ToString()!="")
				{
					model.enterTime=DateTime.Parse(ds.Tables[0].Rows[0]["enterTime"].ToString());
				}
																																				model.Marks= ds.Tables[0].Rows[0]["Marks"].ToString();
																										
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
			strSql.Append(" FROM tbClassInfo ");
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
			strSql.Append(" FROM tbClassInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
        }


        #region ExtendMethod
        /// <summary>
        /// 根据视图ClassInfoView获得数据列表
        /// </summary>
        public DataSet GetListByClassInfoView(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ClassInfoView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
             
        #endregion

    }
}

