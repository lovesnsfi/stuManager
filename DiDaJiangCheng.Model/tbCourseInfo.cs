using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.Model{
	 	//tbCourseInfo
		public class tbCourseInfo
	{
   		     
      	/// <summary>
		/// 课程编号
        /// </summary>		
		private int _courseid;
        public int CourseId
        {
            get{ return _courseid; }
            set{ _courseid = value; }
        }        
		/// <summary>
		/// 班级编号
        /// </summary>		
		private int _classid;
        public int ClassId
        {
            get{ return _classid; }
            set{ _classid = value; }
        }        
		/// <summary>
		/// 课程名称
        /// </summary>		
		private string _coursename;
        public string CourseName
        {
            get{ return _coursename; }
            set{ _coursename = value; }
        }        
		/// <summary>
		/// 学期
        /// </summary>		
		private string _semester;
        public string Semester
        {
            get{ return _semester; }
            set{ _semester = value; }
        }        
		   
	}
}

