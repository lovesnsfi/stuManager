using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using DiDaJiangCheng.Common;
using DiDaJiangCheng.Model;
namespace DiDaJiangCheng.BLL
{
    //tbCourseInfo
    public partial class tbCourseInfo
    {

        private readonly DiDaJiangCheng.DAL.tbCourseInfo dal = new DiDaJiangCheng.DAL.tbCourseInfo();
        public tbCourseInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CourseId)
        {
            return dal.Exists(CourseId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbCourseInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DiDaJiangCheng.Model.tbCourseInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int CourseId)
        {

            return dal.Delete(CourseId);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string CourseIdlist)
        {
            return dal.DeleteList(CourseIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbCourseInfo GetModel(int CourseId)
        {

            return dal.GetModel(CourseId);
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
        public List<DiDaJiangCheng.Model.tbCourseInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbCourseInfo> DataTableToList(DataTable dt)
        {
            List<DiDaJiangCheng.Model.tbCourseInfo> modelList = new List<DiDaJiangCheng.Model.tbCourseInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DiDaJiangCheng.Model.tbCourseInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DiDaJiangCheng.Model.tbCourseInfo();
                    if (dt.Rows[n]["CourseId"].ToString() != "")
                    {
                        model.CourseId = int.Parse(dt.Rows[n]["CourseId"].ToString());
                    }
                    if (dt.Rows[n]["ClassId"].ToString() != "")
                    {
                        model.ClassId = int.Parse(dt.Rows[n]["ClassId"].ToString());
                    }
                    model.CourseName = dt.Rows[n]["CourseName"].ToString();
                    model.Semester = dt.Rows[n]["Semester"].ToString();


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
        /// 根据视图CourseInfoView查询
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListByCourseInfoView(string strWhere)
        {
            return dal.GetListByCourseInfoView(strWhere);
        }
         
        #endregion

    }
}