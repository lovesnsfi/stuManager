using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.DAL
{
	 	//tbCourseInfo
		public partial class tbCourseInfo
	{
   		     
		public bool Exists(int CourseId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tbCourseInfo");
			strSql.Append(" where ");
			                                       strSql.Append(" CourseId = @CourseId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@CourseId", SqlDbType.Int,4)
			};
			parameters[0].Value = CourseId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DiDaJiangCheng.Model.tbCourseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tbCourseInfo(");			
            strSql.Append("ClassId,CourseName,Semester");
			strSql.Append(") values (");
            strSql.Append("@ClassId,@CourseName,@Semester");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@ClassId", SqlDbType.Int,4) ,            
                        new SqlParameter("@CourseName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Semester", SqlDbType.NVarChar,50)             
              
            };
			            
            parameters[0].Value = model.ClassId;                        
            parameters[1].Value = model.CourseName;                        
            parameters[2].Value = model.Semester;                        
			   
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
		public bool Update(DiDaJiangCheng.Model.tbCourseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tbCourseInfo set ");
			                                                
            strSql.Append(" ClassId = @ClassId , ");                                    
            strSql.Append(" CourseName = @CourseName , ");                                    
            strSql.Append(" Semester = @Semester  ");            			
			strSql.Append(" where CourseId=@CourseId ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@CourseId", SqlDbType.Int,4) ,            
                        new SqlParameter("@ClassId", SqlDbType.Int,4) ,            
                        new SqlParameter("@CourseName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Semester", SqlDbType.NVarChar,50)             
              
            };
						            
            parameters[0].Value = model.CourseId;                        
            parameters[1].Value = model.ClassId;                        
            parameters[2].Value = model.CourseName;                        
            parameters[3].Value = model.Semester;                        
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
		public bool Delete(int CourseId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbCourseInfo ");
			strSql.Append(" where CourseId=@CourseId");
						SqlParameter[] parameters = {
					new SqlParameter("@CourseId", SqlDbType.Int,4)
			};
			parameters[0].Value = CourseId;


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
		public bool DeleteList(string CourseIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tbCourseInfo ");
			strSql.Append(" where ID in ("+CourseIdlist + ")  ");
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
		public DiDaJiangCheng.Model.tbCourseInfo GetModel(int CourseId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CourseId, ClassId, CourseName, Semester  ");			
			strSql.Append("  from tbCourseInfo ");
			strSql.Append(" where CourseId=@CourseId");
						SqlParameter[] parameters = {
					new SqlParameter("@CourseId", SqlDbType.Int,4)
			};
			parameters[0].Value = CourseId;

			
			DiDaJiangCheng.Model.tbCourseInfo model=new DiDaJiangCheng.Model.tbCourseInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["CourseId"].ToString()!="")
				{
					model.CourseId=int.Parse(ds.Tables[0].Rows[0]["CourseId"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["ClassId"].ToString()!="")
				{
					model.ClassId=int.Parse(ds.Tables[0].Rows[0]["ClassId"].ToString());
				}
																																				model.CourseName= ds.Tables[0].Rows[0]["CourseName"].ToString();
																																model.Semester= ds.Tables[0].Rows[0]["Semester"].ToString();
																										
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
			strSql.Append(" FROM tbCourseInfo ");
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
			strSql.Append(" FROM tbCourseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
        }

        #region ExtendMethod
        /// <summary>
        /// 根据视图CourseInfoView查询
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListByCourseInfoView(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM CourseInfoView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
		

        #endregion
    }
}

