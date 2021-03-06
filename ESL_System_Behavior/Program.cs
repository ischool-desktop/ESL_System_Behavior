﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FISCA;
using FISCA.Presentation;
using K12.Presentation;
using FISCA.Permission;


namespace ESL_System_Behavior
{
    public class Program
    {
        //2018/4/11 穎驊因應康橋英文系統、弘文ESL 專案 ，開始建構教務作業ESL 評分樣版設定
        [FISCA.MainMethod()]
        public static void Main()
        {
            {
                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"].Image = Properties.Resources.blackboard_config_64;

                Catalog ribbon = RoleAclSource.Instance["課程"]["ESL課程"];
                ribbon.Add(new RibbonFeature("AE1E3C3A - 5F63 - 4776 - 8ECB - 5CB76EDCE74F", "設定Behavior General Commend清單"));

                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"]["設定Behavior General Commend清單"].Enable = UserAcl.Current["AE1E3C3A - 5F63 - 4776 - 8ECB - 5CB76EDCE74F"].Executable;

                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"]["設定Behavior General Commend清單"].Click += delegate
                {
                    Form.BehaviorCommentSettingForm bcsf = new Form.BehaviorCommentSettingForm();

                    bcsf.ShowDialog();
                };
            }
            {
                Catalog ribbon = RoleAclSource.Instance["課程"]["ESL課程"];
                ribbon.Add(new RibbonFeature("84615CE1 - E1B7 - 43A3 - AF91 - F33B95F0C960", "設定Attendance假別對照"));

                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"]["設定Attendance假別對照"].Enable = UserAcl.Current["84615CE1 - E1B7 - 43A3 - AF91 - F33B95F0C960"].Executable;

                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"]["設定Attendance假別對照"].Click += delegate
                {
                    Form.AbsenceMappingForm amf = new Form.AbsenceMappingForm();

                    amf.ShowDialog();
                };
            }
            {
                Catalog ribbon = RoleAclSource.Instance["課程"]["ESL課程"];
                ribbon.Add(new RibbonFeature("A052015A - B865 - 49E6 - 861D - 7B3B25B9BB63", "設定Attendance節次對照"));

                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"]["設定Attendance節次對照"].Enable = UserAcl.Current["A052015A - B865 - 49E6 - 861D - 7B3B25B9BB63"].Executable;


                MotherForm.RibbonBarItems["課程", "ESL課程"]["設定"]["設定Attendance節次對照"].Click += delegate
                {
                    Form.AbsencePeriodMappingForm apmf = new Form.AbsencePeriodMappingForm();

                    apmf.ShowDialog();
                };
            }
            {
                Catalog ribbon = RoleAclSource.Instance["課程"]["ESL課程"];
                ribbon.Add(new RibbonFeature("3ECAD583 - F8D8 - 4DFA - 8299 - 312F603A6F0F", "檢視WeeklyReport"));

                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視WeeklyReport"].Enable = UserAcl.Current["3ECAD583 - F8D8 - 4DFA - 8299 - 312F603A6F0F"].Executable;
                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視WeeklyReport"].Size = RibbonBarButton.MenuButtonSize.Medium;
                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視WeeklyReport"].Image = Properties.Resources.admissions_zoom_64;

                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視WeeklyReport"].Click += delegate
                {
                    Form.ViewWeeklyReportForm vwrf = new Form.ViewWeeklyReportForm();

                    vwrf.ShowDialog();

                };
            }
            {
                Catalog ribbon = RoleAclSource.Instance["課程"]["ESL課程"];
                ribbon.Add(new RibbonFeature("BFE3D505-71EE-4CCA-B903-30EAA5F5AF9A", "檢視教師Behavior紀錄"));

                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視Behavior紀錄"].Enable = UserAcl.Current["BFE3D505-71EE-4CCA-B903-30EAA5F5AF9A"].Executable;
                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視Behavior紀錄"].Size = RibbonBarButton.MenuButtonSize.Medium;
                //MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視Behavior紀錄"].Image = Properties.Resources.admissions_zoom_64;
                MotherForm.RibbonBarItems["課程", "ESL課程"]["檢視Behavior紀錄"].Click += delegate
                {
                    Form.ViewBehaviorInputForm vbif = new Form.ViewBehaviorInputForm();

                    vbif.ShowDialog();
                };

            }
        }
    }
}
