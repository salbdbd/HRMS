using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Framework;
using HRMSModelDBContext.Diciplinary_Action.Model;

namespace HRMSModelDBContext.Diciplinary_Action.DBContext
{
    class NoticeofEnquiry:Connection
    {
        public static bool NoticeofEnquirySave(NoticeofEnquiryModel noticeofEnquiry)
        {
            using (var conn = new SqlConnection(Connection.ConnectionString()))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_NoticeOfEnquiry", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", noticeofEnquiry.ID);
                        cmd.Parameters.AddWithValue("@NoticeID", noticeofEnquiry.NoticeID);
                        cmd.Parameters.AddWithValue("@EmpCode", noticeofEnquiry.EmpCode);
                        cmd.Parameters.AddWithValue("@DateOfEnquiry", noticeofEnquiry.DateOfEnquiry);
                        cmd.Parameters.AddWithValue("@DateOfNoticeIssue", noticeofEnquiry.DateOfNoticeIssue);
                        cmd.Parameters.AddWithValue("@EnqEmpCode", noticeofEnquiry.EnqEmpCode);
                        cmd.Parameters.AddWithValue("@EmpNote", noticeofEnquiry.EmpNote);
                        cmd.Parameters.AddWithValue("@Venue", noticeofEnquiry.Venue);
                        cmd.Parameters.AddWithValue("@Note", noticeofEnquiry.Note);
                        cmd.Parameters.AddWithValue("@UserID", noticeofEnquiry.UserID);
                        cmd.Parameters.AddWithValue("@CompanyID", noticeofEnquiry.CompanyID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
