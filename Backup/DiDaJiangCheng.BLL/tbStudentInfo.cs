using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using DiDaJiangCheng.Common;
using DiDaJiangCheng.Model;
namespace DiDaJiangCheng.BLL
{
    //tbStudentInfo
    public partial class tbStudentInfo
    {

        private readonly DiDaJiangCheng.DAL.tbStudentInfo dal = new DiDaJiangCheng.DAL.tbStudentInfo();
        public tbStudentInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string StuNo)
        {
            return dal.Exists(StuNo);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbStudentInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DiDaJiangCheng.Model.tbStudentInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int StuId)
        {

            return dal.Delete(StuId);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string StuIdlist)
        {
            return dal.DeleteList(StuIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbStudentInfo GetModel(int StuId)
        {

            return dal.GetModel(StuId);
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbStudentInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbStudentInfo> DataTableToList(DataTable dt)
        {
            List<DiDaJiangCheng.Model.tbStudentInfo> modelList = new List<DiDaJiangCheng.Model.tbStudentInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DiDaJiangCheng.Model.tbStudentInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DiDaJiangCheng.Model.tbStudentInfo();
                    if (dt.Rows[n]["StuId"].ToString() != "")
                    {
                        model.StuId = int.Parse(dt.Rows[n]["StuId"].ToString());
                    }
                    model.StuNo = dt.Rows[n]["StuNo"].ToString();
                    model.StuName = dt.Rows[n]["StuName"].ToString();
                    model.StuSex = dt.Rows[n]["StuSex"].ToString();
                    model.StuNation = dt.Rows[n]["StuNation"].ToString();
                    model.StuFamilyAddress = dt.Rows[n]["StuFamilyAddress"].ToString();
                    model.StuContact = dt.Rows[n]["StuContact"].ToString();
                    model.Stupolitics = dt.Rows[n]["Stupolitics"].ToString();
                    model.StuPostCode = dt.Rows[n]["StuPostCode"].ToString();
                    if (dt.Rows[n]["ClassId"].ToString() != "")
                    {
                        model.ClassId = int.Parse(dt.Rows[n]["ClassId"].ToString());
                    }
                    if (dt.Rows[n]["StuPhoto"].ToString() != "")
                    {
                        model.StuPhoto = (byte[])dt.Rows[n]["StuPhoto"];
                    }


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

        #region ExtendMethod
        /// <summary>
        /// 根据StudentInfoView视图获得数据列表
        /// </summary>
        public DataSet GetListByStudentInfoView(string strWhere)
        {
            return dal.GetListByStudentInfoView(strWhere);
        }

        /// <summary>
        /// 根据StuNo得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbStudentInfo GetModel(string StuNo)
        {
            return dal.GetModel(StuNo);
        }

         /// <summary>
        /// 根据学生学号，得到该学生的所有课程
        /// </summary>
        /// <param name="StuNo"></param>
        /// <returns></returns>
        public DataSet GetStuCourseInfo(string StuNo)
        {
            return dal.GetStuCourseInfo(StuNo);
        }
        #endregion

    }
}