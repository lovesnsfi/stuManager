using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
namespace DiDaJiangCheng.DAL
{
    //tbStudentInfo
    public partial class tbStudentInfo
    {

        public bool Exists(string StuNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbStudentInfo");
            strSql.Append(" where ");
            strSql.Append(" StuNo = @StuNo  ");
            SqlParameter[] parameters = {
					new SqlParameter("@StuNo", SqlDbType.NVarChar,50)			};
            parameters[0].Value = StuNo;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbStudentInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tbStudentInfo(");
            strSql.Append("StuNo,StuName,StuSex,StuNation,StuFamilyAddress,StuContact,Stupolitics,StuPostCode,ClassId,StuPhoto");
            strSql.Append(") values (");
            strSql.Append("@StuNo,@StuName,@StuSex,@StuNation,@StuFamilyAddress,@StuContact,@Stupolitics,@StuPostCode,@ClassId,@StuPhoto");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@StuNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuSex", SqlDbType.NVarChar,2) ,            
                        new SqlParameter("@StuNation", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuFamilyAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@StuContact", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Stupolitics", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuPostCode", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ClassId", SqlDbType.Int,4) ,            
                        new SqlParameter("@StuPhoto", SqlDbType.Image)             
              
            };

            parameters[0].Value = model.StuNo;
            parameters[1].Value = model.StuName;
            parameters[2].Value = model.StuSex;
            parameters[3].Value = model.StuNation;
            parameters[4].Value = model.StuFamilyAddress;
            parameters[5].Value = model.StuContact;
            parameters[6].Value = model.Stupolitics;
            parameters[7].Value = model.StuPostCode;
            parameters[8].Value = model.ClassId;
            parameters[9].Value = model.StuPhoto;

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
        public bool Update(DiDaJiangCheng.Model.tbStudentInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbStudentInfo set ");

            strSql.Append(" StuNo = @StuNo , ");
            strSql.Append(" StuName = @StuName , ");
            strSql.Append(" StuSex = @StuSex , ");
            strSql.Append(" StuNation = @StuNation , ");
            strSql.Append(" StuFamilyAddress = @StuFamilyAddress , ");
            strSql.Append(" StuContact = @StuContact , ");
            strSql.Append(" Stupolitics = @Stupolitics , ");
            strSql.Append(" StuPostCode = @StuPostCode , ");
            strSql.Append(" ClassId = @ClassId , ");
            strSql.Append(" StuPhoto = @StuPhoto  ");
            strSql.Append(" where StuId=@StuId ");

            SqlParameter[] parameters = {
			            new SqlParameter("@StuId", SqlDbType.Int,4) ,            
                        new SqlParameter("@StuNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuSex", SqlDbType.NVarChar,2) ,            
                        new SqlParameter("@StuNation", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuFamilyAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@StuContact", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Stupolitics", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@StuPostCode", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ClassId", SqlDbType.Int,4) ,            
                        new SqlParameter("@StuPhoto", SqlDbType.Image)             
              
            };

            parameters[0].Value = model.StuId;
            parameters[1].Value = model.StuNo;
            parameters[2].Value = model.StuName;
            parameters[3].Value = model.StuSex;
            parameters[4].Value = model.StuNation;
            parameters[5].Value = model.StuFamilyAddress;
            parameters[6].Value = model.StuContact;
            parameters[7].Value = model.Stupolitics;
            parameters[8].Value = model.StuPostCode;
            parameters[9].Value = model.ClassId;
            parameters[10].Value = model.StuPhoto;
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
        public bool Delete(int StuId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbStudentInfo ");
            strSql.Append(" where StuId=@StuId");
            SqlParameter[] parameters = {
					new SqlParameter("@StuId", SqlDbType.Int,4)
			};
            parameters[0].Value = StuId;


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
        public bool DeleteList(string StuIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tbStudentInfo ");
            strSql.Append(" where ID in (" + StuIdlist + ")  ");
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
        public DiDaJiangCheng.Model.tbStudentInfo GetModel(int StuId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select StuId, StuNo, StuName, StuSex, StuNation, StuFamilyAddress, StuContact, Stupolitics, StuPostCode, ClassId, StuPhoto  ");
            strSql.Append("  from tbStudentInfo ");
            strSql.Append(" where StuId=@StuId");
            SqlParameter[] parameters = {
					new SqlParameter("@StuId", SqlDbType.Int,4)
			};
            parameters[0].Value = StuId;


            DiDaJiangCheng.Model.tbStudentInfo model = new DiDaJiangCheng.Model.tbStudentInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["StuId"].ToString() != "")
                {
                    model.StuId = int.Parse(ds.Tables[0].Rows[0]["StuId"].ToString());
                }
                model.StuNo = ds.Tables[0].Rows[0]["StuNo"].ToString();
                model.StuName = ds.Tables[0].Rows[0]["StuName"].ToString();
                model.StuSex = ds.Tables[0].Rows[0]["StuSex"].ToString();
                model.StuNation = ds.Tables[0].Rows[0]["StuNation"].ToString();
                model.StuFamilyAddress = ds.Tables[0].Rows[0]["StuFamilyAddress"].ToString();
                model.StuContact = ds.Tables[0].Rows[0]["StuContact"].ToString();
                model.Stupolitics = ds.Tables[0].Rows[0]["Stupolitics"].ToString();
                model.StuPostCode = ds.Tables[0].Rows[0]["StuPostCode"].ToString();
                if (ds.Tables[0].Rows[0]["ClassId"].ToString() != "")
                {
                    model.ClassId = int.Parse(ds.Tables[0].Rows[0]["ClassId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StuPhoto"].ToString() != "")
                {
                    model.StuPhoto = (byte[])ds.Tables[0].Rows[0]["StuPhoto"];
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
            strSql.Append(" FROM tbStudentInfo ");
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
            strSql.Append(" FROM tbStudentInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #region ExtendMethod
        /// <summary>
        /// 根据StudentInfoView视图获得数据列表
        /// </summary>
        public DataSet GetListByStudentInfoView(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM StudentInfoView ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据StuNo得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbStudentInfo GetModel(string StuNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select StuId, StuNo, StuName, StuSex, StuNation, StuFamilyAddress, StuContact, Stupolitics, StuPostCode, ClassId, StuPhoto  ");
            strSql.Append("  from tbStudentInfo ");
            strSql.Append(" where StuNo=@StuNo");
            SqlParameter[] parameters = {
					new SqlParameter("@StuNo", SqlDbType.NVarChar)
			};
            parameters[0].Value = StuNo;


            DiDaJiangCheng.Model.tbStudentInfo model = new DiDaJiangCheng.Model.tbStudentInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["StuId"].ToString() != "")
                {
                    model.StuId = int.Parse(ds.Tables[0].Rows[0]["StuId"].ToString());
                }
                model.StuNo = ds.Tables[0].Rows[0]["StuNo"].ToString();
                model.StuName = ds.Tables[0].Rows[0]["StuName"].ToString();
                model.StuSex = ds.Tables[0].Rows[0]["StuSex"].ToString();
                model.StuNation = ds.Tables[0].Rows[0]["StuNation"].ToString();
                model.StuFamilyAddress = ds.Tables[0].Rows[0]["StuFamilyAddress"].ToString();
                model.StuContact = ds.Tables[0].Rows[0]["StuContact"].ToString();
                model.Stupolitics = ds.Tables[0].Rows[0]["Stupolitics"].ToString();
                model.StuPostCode = ds.Tables[0].Rows[0]["StuPostCode"].ToString();
                if (ds.Tables[0].Rows[0]["ClassId"].ToString() != "")
                {
                    model.ClassId = int.Parse(ds.Tables[0].Rows[0]["ClassId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StuPhoto"].ToString() != "")
                {
                    model.StuPhoto = (byte[])ds.Tables[0].Rows[0]["StuPhoto"];
                }

                return model;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// 根据学生学号，得到该学生的所有课程
        /// </summary>
        /// <param name="StuNo"></param>
        /// <returns></returns>
        public DataSet GetStuCourseInfo(string StuNo)
        {
            string strSql = "SELECT a.*,b.CourseId,b.CourseName FROM dbo.tbStudentInfo a INNER JOIN dbo.tbCourseInfo b ON a.ClassId=b.ClassId";
            strSql += " where a.StuNo=@StuNo";
            SqlParameter[] par ={
                                    new SqlParameter("@StuNo",StuNo)
                               };
            return DbHelperSQL.Query(strSql, par);
        }
        #endregion
    }
}

