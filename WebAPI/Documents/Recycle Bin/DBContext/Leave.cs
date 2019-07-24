using Dapper.Framework;
using HRMS.Models.Leave;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRMS.DbContext
{
    public class Leave
    {
        public static bool SaveLeaveType(LeaveTypeModel leaveType)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                object leavTypeObj = leaveType;
                int rowAffect = con.Execute("sp_Leavetype_New", param: leavTypeObj, commandType: CommandType.StoredProcedure);
                return rowAffect > 0;
            }
        }

        public static bool Apply(LeaveApplyModel leaveApply)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                var applyObj = new
                {
                    leaveApply.ID,
                    leaveApply.EmpCode,
                    leaveApply.LSDate,
                    leaveApply.LEDate,
                    leaveApply.LADate,
                    leaveApply.AccepteDuration,
                    leaveApply.LTypedID,
                    leaveApply.UnAccepteDuration,
                    leaveApply.ReferanceEmpcode,
                    leaveApply.Withpay,
                    leaveApply.AppType,
                    leaveApply.YYYYMMDD,
                    leaveApply.CompanyID,
                    leaveApply.ApplyTo,
                    leaveApply.Reason,
                    leaveApply.EmgContructNo,
                    leaveApply.EmgAddress,
                    leaveApply.UserName
                };
                int rowAffect = con.Execute("INSertupdateLeaveInfo", param: applyObj, commandType: CommandType.StoredProcedure);
                return rowAffect > 0;
            }

        }

        public static bool ManualEntry(List<LeaveApplyModel> manualLeaveList)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in manualLeaveList)
                        {
                            object manualLeaveObj = new
                            {
                                item.EmpCode,
                                item.LSDate,
                                item.LEDate,
                                item.LADate,
                                item.AccepteDuration,
                                item.LTypedID,
                                item.Withpay,
                                item.AppType,
                                item.Grandtype,
                                item.CompanyID,
                                item.Reason,
                                item.EmgContructNo,
                                item.EmgAddress
                            };
                            int rowAffect = con.Execute("INSertManualLeave", param: manualLeaveObj, transaction: tran, commandType: CommandType.StoredProcedure);
                            if (rowAffect == 0)
                            {
                                throw new Exception("Failed to Manual Setup!");
                            }
                        }
                        tran.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        return false; ;
                    }
                }
            }
        }

        public static bool UpdateLeaveInfo(List<LeaveApplyModel> leaveInfoList)
        {
            using (var con = new SqlConnection())
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in leaveInfoList)
                        {
                            object leaveInfoObj = new
                            {
                                item.ID,
                                item.EmpCode,
                                item.LSDate,
                                item.LEDate,
                                item.LADate,
                                item.AccepteDuration,
                                item.LTypedID,
                                item.Withpay,
                                item.Grandtype,
                                item.AppType,
                                item.CompanyID
                            };
                            int rowAffect = con.Execute("UpdateLeaveLeaveInfo", param: leaveInfoObj, transaction: tran, commandType: CommandType.StoredProcedure);
                            if (rowAffect == 0)
                            {
                                throw new Exception("Failed to update!");
                            }
                        }
                        tran.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }

        public static bool OpeningBalenceInsert(LeaveBalenceModel leaveBalence)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                object leaveBalenceObj = new
                {
                    leaveBalence.EmpCode,
                    leaveBalence.LType,
                    leaveBalence.YearID,
                    leaveBalence.Qty,
                    leaveBalence.DATE,
                    leaveBalence.Note,
                    leaveBalence.CompanyID
                };
                int rowAffect = con.Execute("sp_EarnLeaveBalance_Insert", param: leaveBalenceObj, commandType: CommandType.StoredProcedure);
                return rowAffect > 0;
            }
        }

        public static bool CarryForward(LeaveBalenceModel leaveBalence)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                var leaveBalenceObj = new
                {
                    leaveBalence.EmpCode,
                    leaveBalence.LType,
                    leaveBalence.YearID,
                    leaveBalence.Qty,
                    leaveBalence.DATE,
                    leaveBalence.Note,
                    leaveBalence.CompanyID
                };
                int rowAffect = con.Execute("sp_CarryForword_Insert", param: leaveBalenceObj, commandType: CommandType.StoredProcedure);
                return rowAffect > 0;
            }
        }

        public static bool EncashmentDayInsert(LeaveBalenceModel leaveBalence)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                var leaveBalenceObj = new
                {
                    leaveBalence.EmpCode,
                    leaveBalence.LType,
                    leaveBalence.YearID,
                    leaveBalence.Qty,
                    leaveBalence.DATE,
                    leaveBalence.Note,
                    leaveBalence.CompanyID
                };
                int rowAffect = con.Execute("s" +
                    "p_EncashmentDay_Insert", param: leaveBalenceObj, commandType: CommandType.StoredProcedure);
                return rowAffect > 0;
            }
        }

        public static bool SubstituteLeaveDay(LeaveBalenceModel leaveBalence)
        {
            using (var con = new SqlConnection(Connection.ConnectionString()))
            {
                var leaveBalenceObj = new
                {
                    leaveBalence.EmpCode,
                    leaveBalence.LType,
                    leaveBalence.YearID,
                    leaveBalence.Qty,
                    leaveBalence.DATE,
                    leaveBalence.Note,
                    leaveBalence.CompanyID
                };
                int rowAffect = con.Execute("sp_SubstituteLeaveDay_Insert", param: leaveBalenceObj, commandType: CommandType.StoredProcedure);
                return rowAffect > 0;
            }
        }
    }
}