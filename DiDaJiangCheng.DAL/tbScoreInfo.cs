using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
namespace DiDaJiangCheng.DAL
{
    //tbScoreInfo
    public partial class tbScoreInfo
    {

        public bool Exists(int filedaScoreId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbScoreInfo");
            strSql.Append(" where ");
            strSql.Append(" filedaScoreId = @filedaScoreId  ");
            SqlParameter[] parameters = {
					new SqlParameter("@filedaScoreId", SqlDbType.Int,4)
			};
            parameters[0].Value = filedaScoreId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbScoreInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbScoreInfo(");
            strSql.Append("filedStuNo,filedCourseId,filedScore");
            strSql.Append(") values (");
            strSql.Append("@filedStuNo,@filedCourseId,@filedScore");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@filedStuNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@filedCourseId", SqlDbType.Int,4) ,            
                        new SqlParameter("@filedScore", SqlDbType.Float,8)             
              
            };

            parameters[0].Value = model.filedStuNo;
            parameters[1].Value = model.filedCourseId;
            parameters[2].Value = model.filedScore;

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
        public bool Update(DiDaJiangCheng.Model.tbScoreInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbScoreInfo set ");

            strSql.Append(" filedStuNo = @filedStuNo , ");
            strSql.Append(" filedCourseId = @filedCourseId , ");
            strSql.Append(" filedScore = @filedScore  ");
            strSql.Append(" where filedaScoreId=@filedaScoreId ");

            SqlParameter[] parameters = {
			            new SqlParameter("@filedaScoreId", SqlDbType.Int,4) ,            
                        new SqlParameter("@filedStuNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@filedCourseId", SqlDbType.Int,4) ,            
                        new SqlParameter("@filedScore", SqlDbType.Float,8)             
              
            };

            parameters[0].Value = model.filedaScoreId;
            parameters[1].Value = model.filedStuNo;
            parameters[2].Value = model.filedCourseId;
            parameters[3].Value = model.filedScore;
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
        public bool Delete(int filedaScoreId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbScoreInfo ");
            strSql.Append(" where filedaScoreId=@filedaScoreId");
            SqlParameter[] parameters = {
					new SqlParameter("@filedaScoreId", SqlDbType.Int,4)
			};
            parameters[0].Value = filedaScoreId;


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
        public bool DeleteList(string filedaScoreIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbScoreInfo ");
            strSql.Append(" where ID in (" + filedaScoreIdlist + ")  ");
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
        public DiDaJiangCheng.Model.tbScoreInfo GetModel(int filedaScoreId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select filedaScoreId, filedStuNo, filedCourseId, filedScore  ");
            strSql.Append("  from tbScoreInfo ");
            strSql.Append(" where filedaScoreId=@filedaScoreId");
            SqlParameter[] parameters = {
					new SqlParameter("@filedaScoreId", SqlDbType.Int,4)
			};
            parameters[0].Value = filedaScoreId;


            DiDaJiangCheng.Model.tbScoreInfo model = new DiDaJiangCheng.Model.tbScoreInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["filedaScoreId"].ToString() != "")
                {
                    model.filedaScoreId = int.Parse(ds.Tables[0].Rows[0]["filedaScoreId"].ToString());
                }
                model.filedStuNo = ds.Tables[0].Rows[0]["filedStuNo"].ToString();
                if (ds.Tables[0].Rows[0]["filedCourseId"].ToString() != "")
                {
                    model.filedCourseId = int.Parse(ds.Tables[0].Rows[0]["filedCourseId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["filedScore"].ToString() != "")
                {
                    model.filedScore = decimal.Parse(ds.Tables[0].Rows[0]["filedScore"].ToString());
                }

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
            strSql.Append(" FROM tbScoreInfo ");
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
            strSql.Append(" FROM tbScoreInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }



        #region
        /// <summary>
        /// 根据视图ScoreInfo获得数据列表
        /// </summary>
        public DataSet GetListByScoreInfoView(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ScoreInfoView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
		
        #endregion


    }
}

