using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
namespace DiDaJiangCheng.DAL
{
    //tbUserInfo
    public partial class tbUserInfo
    {

        public bool Exists(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbUserInfo");
            strSql.Append(" where ");
            strSql.Append(" UserName = @UserName  ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)			};
            parameters[0].Value = UserName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbUserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbUserInfo(");
            strSql.Append("UserName,UserPassword");
            strSql.Append(") values (");
            strSql.Append("@UserName,@UserPassword");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@UserName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@UserPassword", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.UserName;
            parameters[1].Value = model.UserPassword;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(DiDaJiangCheng.Model.tbUserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbUserInfo set ");

            strSql.Append(" UserName = @UserName , ");
            strSql.Append(" UserPassword = @UserPassword  ");
            strSql.Append(" where UserId=@UserId ");

            SqlParameter[] parameters = {
			            new SqlParameter("@UserId", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@UserPassword", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.UserId;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.UserPassword;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbUserInfo ");
            strSql.Append(" where UserId=@UserId");
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
            parameters[0].Value = UserId;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string UserIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbUserInfo ");
            strSql.Append(" where ID in (" + UserIdlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public DiDaJiangCheng.Model.tbUserInfo GetModel(int UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserId, UserName, UserPassword  ");
            strSql.Append("  from tbUserInfo ");
            strSql.Append(" where UserId=@UserId");
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
            parameters[0].Value = UserId;


            DiDaJiangCheng.Model.tbUserInfo model = new DiDaJiangCheng.Model.tbUserInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["UserId"].ToString() != "")
                {
                    model.UserId = int.Parse(ds.Tables[0].Rows[0]["UserId"].ToString());
                }
                model.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                model.UserPassword = ds.Tables[0].Rows[0]["UserPassword"].ToString();

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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tbUserInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM tbUserInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #region  ExtendMethod
        //登陆的方法
        public DataTable CheckLogin(string UserName,string PassWord)
        {
            string strSql = "SELECT * FROM dbo.tbUserInfo WHERE UserName=@UserName AND UserPassword=@UserPassword";
            SqlParameter[] parm = { 
                                  new SqlParameter("@UserName",UserName),
                                  new SqlParameter("@UserPassword",PassWord)
                                  };
            DataSet ds = DbHelperSQL.Query(strSql, parm);
            if (ds!=null&&ds.Tables.Count>0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbUserInfo GetModel(string UserName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserId, UserName, UserPassword  ");
            strSql.Append("  from tbUserInfo ");
            strSql.Append(" where UserName=@UserName");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar)
			};
            parameters[0].Value = UserName;


            DiDaJiangCheng.Model.tbUserInfo model = new DiDaJiangCheng.Model.tbUserInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["UserId"].ToString() != "")
                {
                    model.UserId = int.Parse(ds.Tables[0].Rows[0]["UserId"].ToString());
                }
                model.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                model.UserPassword = ds.Tables[0].Rows[0]["UserPassword"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}

