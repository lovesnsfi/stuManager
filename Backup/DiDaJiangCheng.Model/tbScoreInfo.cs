using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.Model{
	 	//tbScoreInfo
		public class tbScoreInfo
	{
   		     
      	/// <summary>
		/// 成绩编号
        /// </summary>		
		private int _filedascoreid;
        public int filedaScoreId
        {
            get{ return _filedascoreid; }
            set{ _filedascoreid = value; }
        }        
		/// <summary>
		/// 学生学号
        /// </summary>		
		private string _filedstuno;
        public string filedStuNo
        {
            get{ return _filedstuno; }
            set{ _filedstuno = value; }
        }        
		/// <summary>
		/// 课程名称
        /// </summary>		
		private int _filedcourseid;
        public int filedCourseId
        {
            get{ return _filedcourseid; }
            set{ _filedcourseid = value; }
        }        
		/// <summary>
		/// 课程成绩
        /// </summary>		
		private decimal _filedscore;
        public decimal filedScore
        {
            get{ return _filedscore; }
            set{ _filedscore = value; }
        }        
		   
	}
}

