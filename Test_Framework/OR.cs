using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConsole
{
    [TestFixture]
    public class OR
    {
        // Login Page
        public static String Login_HeaderCloudConsole = "Header#xpath=//h1";
        public static String LabelLogin = "Label_Login#xpath=//h2[contains(text(),'Log In')]";
        public static String Login_msg_UsrPwd = "Val_usrPwd#xpath=//p[contains(text(),'Please enter your username and password.')]";
        public static String Login_info = "Login_info#xpath=//p[contains(text(),'For more information, or to request additional privileges, please')]";
        public static String Login_info2 = "Login_info2#xpath=//a[contains(text(),'contact the Aspire Core Technology team')]";
        public static String Login_AccountInfo = "AccountInfo#xpath=//*[contains(text(),'Account Information')]";
        public static String Login_Label_Username = "usernameTxt#xpath=//*[@id='UserNameLabel']";
        public static String Login_Label_password = "passwordTxt#xpath=//*[@id='PasswordLabel']";
        public static String Login_Input_username = "username#xpath=//*[@id='username']";
        public static String Login_Input_Password = "Password#xpath=//*[@id='Password']";
        public static String Login_Loginbtn = "Loginbtn#xpath=//button[contains(text(),'Login')]";
        public static String Login_Footer = "Footer#xpath=//*[@class='footer']";
        public static String Login_validation = "validation#xpath=//*[text()='Unable to authenticate using the provided credentials.']";

        // Forgot password
        public static String ForgotPassword = "ForgotPasswordlink#xpath=//*[@href='/forgotpassword']";
        public static String ForgotPassword_Label = "ForgotPasswordLabel#xpath=//*[text()='Forgot Password']";
        public static String ForgotPassword_EnterUserName = "EnterUserName#xpath=//*[text()='Please enter your username.']";
        public static String ForgotPassword_RecoverPassword = "RecoverPassword#xpath=//button[text()='Recover Password']";

        // Home Page
        public static String Home_User = "HeadLoginName#xpath=//*[@id='HeadLoginView_HeadLoginName']";
        public static String Home_Logout = "HeadLoginSatus#xpath=//*[@id='HeadLoginView_HeadLoginStatus']";
        public static String Home_User_icon = "HeadLoginName_Icon#xpath=//*[@class='fa fa-user ml6 posRel']";
        public static String Home_Logout_icon = "HeadLoginSatus_Icon#xpath=//*[@class='fa fa-power-off ml6 posRel']";
        public static String Home_MenuList = "MenuList#xpath=(//*[@id='NavigationMenu']//*[@role='menuitem'])/a";
        public static String Home_Welcome = "Welcome#xpath=(//h1)[2]";

        // Home page Menu

        public static String Home_Menu_Application = "Application#xpath=//*[@href='/application']";
        public static String Home_Menu_users = "users#xpath=//*[@href='/users']";
        public static String Home_Menu_role = "role#xpath=//*[@href='/role']";
        public static String Home_Menu_organization = "organization#xpath=//*[@href='/organization']";
        public static String Home_Menu_organizationType = "organizationType#xpath=//*[@href='/organization/type']";
        public static String Home_Menu_dashboard = "dashboard#xpath=//*[@href='/dashboard']";
        public static String Home_Menu_communications = "communications#xpath=//*[@href='/communications/list']";
        public static String Home_Menu_securitylog = "securitylog#xpath=//*[@href='/securitylog']";
        public static String Home_Menu_urlshortener = "urlshortener#xpath=//*[@href='/urlshortener']";

        // Application
        public static String Application_ActiveTab = "ActiveTab#xpath=//*[@class='active']/a";
        public static String Application_Application_Msg = "Application_Msg#xpath=(//p)[1]";
        public static String Application_APpInfo    = "ApplicationInfo#xpath=//*[@href='#Application']";
        public static String Application_AppID_Label = "label_ApplicationID#xpath=//*[text()='Application ID']";
        public static String Application_AppID = "ApplicationID#xpath=//*[@class='requiredCheck requiredForApp']";
        public static String Application_AppName_Label = "Label_ApplicationName#xpath=//*[text()='Application Name']";
        public static String Application_AppName = "ApplicationName#xpath=//*[@id='applicationName']";
        public static String Application_Description_Label = "Description_Label#xpath=//*[text()='Description']";
        public static String Application_Description = "Description#xpath=//*[@id='description']";
        public static String Application_AppEnable_Label = "AppEnable_Label#xpath=//*[contains(text(),'Application enabled')]";
        public static String Application_AppEnable = "AppEnable#xpath=(//*[@ type='checkbox'])[1]";
        public static String Application_AceptReg_Label = "AceptReg_Label#xpath=//*[contains(text(),'Accepting registrations')]";
        public static String Application_AceptReg = "AceptReg#xpath=(//*[@ type='checkbox'])[2]";

        // Application Company Config
        public static String Application_CConfig = "ApplicationInfo#xpath=//*[@href='#Company']";
        public static String Application_CConfig_Company_Label = "Company_Label#xpath=//*[text()='Company']";
        public static String Application_CConfig_Company = "Company#xpath=//*[@id='company']";
        public static String Application_CConfig_StAddress_Label = "Label_StAddress#xpath=//*[text()='Street Address']";
        public static String Application_CConfig_StAddress = "StAddress#xpath=//*[@id='companyAddress1']";
        public static String Application_CConfig_City_Label = "Label_City#xpath=//*[text()='City']";
        public static String Application_CConfig_City = "City#xpath=//*[@id='companyAddress2']";
        public static String Application_CConfig_StateProvince_Label = "Label_StateProvince#xpath=//*[text()='State/Province']";
        public static String Application_CConfig_StateProvince = "StateProvince#xpath=//*[@id='companyAddress3']";
        public static String Application_CConfig_Zipcode_Label = "Label_Zibcodee#xpath=//*[text()='ZIP/Postal Code']";
        public static String Application_CConfig_Zipcode = "Zibcode#xpath=//*[@id='companyAddress3']";
        public static String Application_CConfig_Email_Label = "Label_Email#xpath=//*[text()='Company Email']";
        public static String Application_CConfig_Email = "Email#xpath=//*[@id='companyAddress3']";
        public static String Application_CConfig_Companyicon = "Companyicon#xpath=//*[@class='fa fa-group fr']";
        public static String Application_CConfig_Streeticon = "Streeticon#xpath=//*[@class='fa fa-building fr']";
        public static String Application_CConfig_Cityicon = "Cityicon#xpath=//*[@class='fa fa-map fr']";
        public static String Application_CConfig_Stateicon = "Stateicon#xpath=//*[@class='fa fa-map-marker fr']";
        public static String Application_CConfig_Zipicon = "Zipicon#xpath=//*[@class='fa fa-building-o fr']";
        public static String Application_CConfig_Emailicon = "Emailicon#xpath=//*[@class='fa fa-send fr']";

        // Application Company Config
        public static String Application_EConfig = "EConfig#xpath=//*[@href='#Email']";
        public static String Application_EConfig_Label_SenderName = "Label_SenderName#xpath=//*[text()='Sender Name']";
        public static String Application_EConfig_SenderName = "SenderName#xpath=//*[@id='emailSenderName']";
        public static String Application_EConfig_Label_ReplyEmail = "Label_ReplytoEmail#xpath=//*[text()='Reply-To Email']";
        public static String Application_EConfig_ReplytoEmail = "ReplytoEmail#xpath=//*[@id='emailReplyTo']";
        public static String Application_EConfig_Label_SupportEmail = "Label_SupportEmail#xpath=//*[text()='Support Email']";
        public static String Application_EConfig_SupportEmail = "SupportEmail#xpath=//*[@id='emailSupport']";
        public static String Application_EConfig_Sendernameicon = "SenderNameicon#xpath=//*[@class='fa fa-smile-o fl']";
        public static String Application_EConfig_ReplytoEmailicon = "ReplytoEmailicon#xpath=//*[@class='fa fa-reply fl']";
        public static String Application_EConfig_EmailSupporticon = "EmailSupporticon#xpath=//*[@class='fa fa-support fl']";

        // Application OAuth Config
        public static String Application_OAuth = "OAuthConfig#xpath=//*[@href='#OAuth']";
        public static String Application_OAuth_Label_GoogleID = "LabelGoogleID#xpath=//*[text()='Google Client ID']";
        public static String Application_OAuth_GoogleID = "GoogleID#xpath=//*[@id='OA_CLIENT_ID_GOOGLE']";
        public static String Application_OAuth_Label_GoogleSecret = "LabelGoogleSecret#xpath=//*[text()='Google Secret']";
        public static String Application_OAuth_GoogleSecret = "GoogleSecret#xpath=//*[@id='OA_CLIENT_SECRET_GOOGLE']";
        public static String Application_OAuth_Label_FBID = "LabelFBID#xpath=//*[text()='Facebook Client ID']";
        public static String Application_OAuth_FBID = "FBID#xpath=//*[@id='OA_CLIENT_ID_FACEBOOK']";
        public static String Application_OAuth_Label_FBSecret = "LabelFBSecret#xpath=//*[text()='Facebook Secret']";
        public static String Application_OAuth_FBSecret = "FBSecret#xpath=//*[@id='OA_CLIENT_SECRET_FACEBOOK']";
        public static String Application_EConfig_GoogleidIcon = "GoogleidIcon#xpath=//*[@class='fa fa-google fl']";
        public static String Application_EConfig_GoogleidSecreetIcon = "GoogleSecreetIcon#xpath=//*[@class='fa fa-google fl']";
        public static String Application_EConfig_FBIDIcon = "FBIDIcon#xpath=(//*[@class='fa fa-facebook-official fl'])[1]";
        public static String Application_EConfig_FBSecreetIcon = "FBSecreetIcon#xpath=(//*[@class='fa fa-facebook-official fl'])[2]";

        // Application Brand COnfiguration
        public static String Application_BCOnfig = "BConfig#xpath=//*[@href='#Brand']";
        public static String Application_Bconfig_WEbsite_Label = "Label_CompanyWebsite#xpath=//*[text()='Company Website']";
        public static String Application_Bconfig_WEbsite = "CompanyWebsite#xpath=//*[@id='companyURL']";
        public static String Application_Bconfig_LogoUrl_Label = "Label_LogoUrl#xpath=//*[text()='Logo URL']";
        public static String Application_Bconfig_LogoUrl = "LogoUrl#xpath=//*[@id='companyLogo']";
        public static String Application_Bconfig_PrimaryColor_Label = "Label_PrimaryColor#xpath=//*[text()='Primary Color(Hex)']";
        public static String Application_Bconfig_PrimaryColor = "PrimaryColor#xpath=//*[@id='PrimaryColor']";
        public static String Application_Bconfig_CSS_Label = "Label_CSS#xpath=//*[text()='CSS URL']";
        public static String Application_Bconfig_CSS = "CSS#xpath=//*[@id='PrimaryColor']";
        public static String Application_Bconfig_FavUrl_Label = "Label_FavUrl#xpath=//*[text()='Favicon URL']";
        public static String Application_Bconfig_FavUrl = "FavUrl#xpath=//*[@id='FavIcon']";
        public static String Application_Bconfig_CompaniwebIcon = "CompaniwebIcon#xpath=//*[@class='fa fa-globe fr']";
        public static String Application_Bconfig_LogoUrlIcon = "LogoUrlIcon#xpath=(//*[@class='fa fa-paint-brush fr'])[1]";
        public static String Application_Bconfig_PrimaryColorIcon = "PrimaryColorIcon#xpath=(//*[@class='fa fa-paint-brush fr'])[2]";
        public static String Application_Bconfig_FavIcon = "FavIcon#xpath=(//*[@class='fa fa-paint-brush fr'])[3]";
        public static String Application_Bconfig_cssURlicon = "cssURlicon#xpath=(//*[@class='fa fa-css3 fr'])";

        // User page
        public static String User_Info = "Info#xpath=(//p)[1]";
        public static String User_Left_UserName = "Left_UserName_Label#xpath=//th[text()='User Name']";
        public static String User_BasicTab = "InfoTab#xpath=//*[@id='basicinfoTab']";
        public static String User_RoleTab = "RoleTab#xpath=//*[@id='roleTab']";
        public static String User_Orgtab = "Org_Tab#xpath=//*[@href='#Organizations']";
        public static String User_SettingTab = "SettingTab#xpath=//*[@href='#Settings']";
        public static String User_ActivityTab = "ActivityTab#xpath=//*[@href='#dashboard']";
        public static String User_ManageTab = "ManageTab#xpath=//*[@href='#Password']";
        public static String User_OrganizationsTab = "OrganizationsTab#xpath=//*[@href='/organization']";
        public static String User_Email_Label = "Email_Label#xpath=//*[@for='Email']";
        public static String User_Email = "Email#xpath=//*[@id='Email']";
        public static String User_userName_Label = "userName_Label#xpath=//*[@for='userName']";
        public static String User_userName = "userName#xpath=//*[@id='userName']";
        public static String User_Phone_Label = "Phone_Label#xpath=//*[@for='Phone']";
        public static String User_Phone = "Phone#xpath=//*[@id='Phone']";
        public static String User_password_Label = "password_Label#xpath=//*[@for='password']";
        public static String User_password = "password#xpath=//*[@id='password']";
        public static String User_confirmPassword_Label = "confirmPassword_Label#xpath=//*[@for='confirmPassword']";
        public static String User_confirmPassword = "confirmPassword#xpath=//*[@id='confirmPassword']";
        public static String User_firstName_Label = "firstName_Label#xpath=//*[@for='firstName']";
        public static String User_firstName = "firstName#xpath=//*[@id='firstName']";
        public static String User_lastName_Label = "lastName_Label#xpath=//*[@for='lastName']";
        public static String User_lastName = "lastName#xpath=//*[@id='lastName']";
        public static String User_UserId_Label = "UserId_Label#xpath=//*[text()='UserId']";
        public static String User_UserId = "UserId#xpath=//*[@id='txtUserid']";
        public static String User_Roles_Label = "Roles_Label#xpath=//h2[text()='Roles']";
        public static String User_Activity_Lock_Account_button = "Lock_Account#xpath=//input[@value='Lock Account']";
        public static String User_Activity_Lock_Account_validation = "Lock_Account_validation#xpath=//*[text()='Are you sure you want to lock this account?']";
        public static String User_CreateSucess = "SucessCreate#xpath=//*[text()='User created successfully']";
        public static String User_CreateValidation = "ValidationCreate#xpath=//*[text()='Account cannot be created when required fields are left blank.']";
        public static String User_Password_validation = "PasswordValidation#xpath=//*[text()='Password and Confirm Password are not same.']";
        public static String User_Activeuser_checkbox = "Activeuser_checkbox#xpath=(//*[@class='aspNetDisabled']//input[@type='checkbox'])[1]";
        public static String User_Activeuser_Label = "Activeuser_Label#xpath=//*[contains(text(),'Active User')]";
        public static String User_ApprovedUser_checkbox = "ApprovedUser_checkbox#xpath=(//*[@class='aspNetDisabled']//input[@type='checkbox'])[2]";
        public static String User_ApprovedUser_Label = "ApprovedUser_Label#xpath=//*[contains(text(),'Approved User')]";
        public static String User_LockedUserValidation = "LockedUserValidation#xpath=//*[@id='basicinfo']//p";

        // Roles
        public static String Roles_Roles_Label = "Roles_Label#xpath=//th[text()='Roles']";
        public static String Roles_RoleName_Label = "RoleName_Label#xpath=//*[text()='Role Name']";
        public static String Roles_RoleName_Edit = "RoleName#xpath=//*[@id='roleName']";
        public static String Roles_RoleName = "RoleName#xpath=//*[@id='_rolename']";
        public static String Roles_RoleName_Roleicon = "Roleicon#xpath=//*[@class='fa fr fa-user labelIcon drag5n']";
        public static String Roles_Delete_sucessmessage = "DeleteSucess#xpath=//*[text()='Role deleted successfully.']";
        public static String Roles_Create_sucessmessage = "CreateSucess#xpath=//*[text()='Role created successfully']";
        public static String Roles_Updated_sucessmessage = "EditedSucess#xpath=//*[text()='Role updated successfully']";
        public static String Roles_Create_failsmessage = "alreadyValidation#xpath=//*[text()='Role Name is already present']";
        public static String Roles_Admin_validation = "Admin_validation#xpath=//*[text()='This role is read-only and may not be changed']";
        public static String Roles_Name_validation = "Name_validation#xpath=//*[text()='Role name is required.']";

        // Organization
        public static String Org_tab = "Org_Tab#xpath=//*[@href='#Organizations']";
        public static String Org_NameLabel = "OrgName_Label#xpath=//*[text()='Organization Name']";
        public static String Org_Name = "Org_Name#xpath=//*[@id='organizationName']";
        public static String Org_Label = "Org_Label#xpath=//th[text()='Organizations']";
        public static String Org_Description_Label = "Description_Label#xpath=//*[text()='Description']";
        public static String Org_description = "description#xpath=//*[@id='description']";
        public static String Org_Type_Label = "OrgType_Label#xpath=//label[text()='Organization Type']";
        public static String Org_Type = "OrgTypename#xpath=//input[@id='organizationType']";
        public static String Org_Enable_Label = "OrgEnable_Label#xpath=//*[contains(text(),'Organization enabled')]";
        public static String Org_Enable_icon = "OrgEnableicon#xpath=//*[contains(text(),'Organization enabled')]/input";
        public static String Org_Nameicon = "OrgNameicon#xpath=(//*[@id='Organizations']//*[@class='fa fr fa-user labelIcon drag5n'])[1]";
        public static String Org_organizationType = "organizationType#xpath=//select[@id='organizationType']";
        public static String Org_Description_icon = "Description_iCon#xpath=(//*[@id='Organizations']//*[@class='fa fr fa-user labelIcon drag5n'])[2]";
        public static String Org_Cancel = "Cancel#xpath=(//*[@value='Cancel'])[2]";
        public static String Org_SaveChanges = "SaveChanges#xpath=(//*[@value='Save Changes'])[1]";
        public static String Org_AddBtn = "Add#xpath=(//*[@id='MainContent_RoleGrid_btnNewRole'])[1]";
        public static String Org_Create_Save = "Create#xpath=(//*[@value='Create'])[1]";
        public static String Org_Create_Cancel = "Cancel#xpath=(//*[@value='Cancel'])[1]";
        public static String Org_Create_Sucess= "CreateSucess#xpath=//*[text()='Organization created successfully']";
        public static String Org_update_Sucess = "updateSucess#xpath=//*[text()='Organization updated successfully']";
        public static String Org_Delete_Sucess = "DeleteSucess#xpath=//*[text()='Organization deleted successfully.']";

        // Organization type
        public static String OrgType_tab = "OrgType_tab#xpath=//a[text()='Organization Types']";
        public static String OrgType_Label = "OrgType_Label#xpath=(//*[text()='Organization Types'])[2]";
        public static String OrgType_Label_Left = "LeftOrgType_Label#xpath=//th[text()='Organization Types']";
        public static String OrgType_OrgtypeName_Label = "OrgtypeName_Label#xpath=//*[text()='Name']";
        public static String OrgType_organizationType = "organizationType#xpath=//*[@id='organizationType']";
        public static String OrgType_Enable = "Enabel#xpath=//*[contains(text(),'Enabled')]";
        public static String OrgType_Enable_Checkbox = "Enable_Checkbox#xpath=//*[@id='OrganizationsType']//*[@type='checkbox']";
        public static String OrgType_AddBtn = "Add#xpath=(//*[@id='MainContent_RoleGrid_btnNewRole'])[2]";
        public static String OrgType_NameIcon = "NameIcon#xpath=(//*[@class='fa fr fa-user labelIcon drag5n'])[3]";
        public static String OrgType_SaveBtn = "SaveBtn#xpath=(//*[@id='OrganizationsType']//input[@value='Create'])[1]";
        public static String OrgType_CancelBtn = "CancelBtn#xpath=(//*[@id='OrganizationsType']//input[@value='Cancel'])[1]";
        public static String OrgType_UpdateName = "UpdateName#xpath=(//*[@id='organizationType'])[2]";
        public static String OrgType_Update_CancelBtn = "UpdateCancelBtn#xpath=(//*[@id='OrganizationsType']//input[@value='Cancel'])[2]";
        public static String OrgType_Update_SaveChanges = "SaveChangesBtn#xpath=(//*[@id='OrganizationsType']//input[@value='Save Changes'])";
        public static String OrgType_CreateBtn = "CreateBtn#xpath=(//input[@value='Create'])[2]";
        public static String OrgType_CreateSucess = "OrgSucess#xpath=//*[text()='Organization Type created successfully']";
        public static String OrgType_UpdatedSucess = "OrgUpdatedSucess#xpath=//*[text()='Organization type updated successfully']";
        public static String OrgType_DeleteSucess = "DeleteSucess#xpath=//*[text()='Organization Type deleted successfully.']";

        // Short URL

        public static String ShortUrltxt = "ShortUrltxt#xpath=//*[text()='Use the fields below to create short URL']";
        public static String ShortUrl_Urltxt = "txt_Urltxt#xpath=//*[text()='URL']";
        public static String ShortUrl_Url_input = "input_Urltxt#xpath=//textarea";
        public static String ShortUrl_CreateBtn = "CreateBtn#xpath=//button[text()='Create']";
        public static String ShortUrl_label = "ShortURlLabel#xpath=//*[text()='Short URL']";
        public static String ShortUrl_get = "ShortURlget#xpath=(//textarea)[2]";
        public static String ShortUrl_DisplayColumn = "DisplayColumn#xpath=//*[contains(text(),'Display Columns')]";
        public static String ShortUrl_DisplayColumn_Segment = "Segment#xpath=//*[text()='Segment']";
        public static String ShortUrl_DisplayColumn_Clicks = "Clicks#xpath=//*[text()='Clicks']";
        public static String ShortUrl_DisplayColumn_CreatedOn = "CreatedOn#xpath=//*[text()='Created On']";
        public static String ShortUrl_DisplayColumn_Expired = "Expired#xpath=//*[text()='Expired']";
        public static String ShortUrl_DisplayColumn_LongUrl = "LongUrl#xpath=//*[text()='Long Url']";
        public static String ShortUrl_DisplayColumn_btnSelectAll = "btn_SelectAll#xpath=//button[contains(text(),'Select all')]";
        public static String ShortUrl_DisplayColumn_btnSelectNone = "btn_Selectnone#xpath=//button[contains(text(),'Select none')]";
        public static String ShortUrl_SearchBox = "SearchBox#xpath=//*[@placeholder='Search...']";
        public static String ShortUrl_label_Segment = "Segment#xpath=//th[contains(text(),'Segment')]";
        public static String ShortUrl_label_Clicks = "Clicks#xpath=//th[contains(text(),'Clicks')]";
        public static String ShortUrl_Label_CreatedOn = "CreatedOn#xpath=//th[contains(text(),'Created On')]";
        public static String ShortUrl_Label_Expired = "Expired#xpath=//th[contains(text(),'Expired')]";
        public static String ShortUrl_LabelLongUrl = "LongUrl#xpath=//th[contains(text(),'Long Url')]";
        public static String ShortUrl_Header_LabelSegment = "LabelSegment#xpath=//th[contains(text(),'Segment')]";
        public static String ShortUrl_Header_LabelClicks = "LabelClicks#xpath=//th[contains(text(),'Clicks')]";
        public static String ShortUrl_Header_LabelCreatedOn = "LabelCreatedOn#xpath=//th[contains(text(),'Created On')]";
        public static String ShortUrl_Header_LabelExpired = "LabelExpired#xpath=//th[contains(text(),'Expired')]";
        public static String ShortUrl_Header_LabelLongUrl = "LabelLongUrl#xpath=//th[contains(text(),'Long Url')]";
        public static String ShortUrl_validation = "validation#xpath=//*[text()='Please provide URL.']";

        // Communication
        public static String Communication_AddNew_Btn = "BtnAddNew#xpath=//*[@value='Add New']";
        public static String Communication_AddCustom_Btn = "BtnAddCustom#xpath=//*[@value='Add Custom']";
        public static String Communication_AddNewCustom_Name_Label = "NameLabel#xpath=//*[@for='name']";
        public static String Communication_AddNewCustom_Name = "Name#xpath=//*[@id='name']";
        public static String Communication_AddNewCustom_communicationType_Label = "communicationTypeLabel#xpath=//*[@for='communicationType']";
        public static String Communication_AddNewCustom_communicationType = "communicationType#xpath=//*[@id='communicationType']";
        public static String Communication_AddNewCustom_Subject_Label = "SubjectLabel#xpath=//*[@for='Subject']";
        public static String Communication_AddNewCustom_Subject = "Subject#xpath=//*[@id='Subject']";
        public static String Communication_AddNewCustom_Description_Label = "DescriptionLabel#xpath=//*[@for='Description']";
        public static String Communication_AddNewCustom_Description = "Description#xpath=//*[@id='Description']";
        public static String Communication_AddNewCustom_Body_Label = "BodyLabel#xpath=//*[@for='Body']";
        public static String Communication_AddNewCustom_Body = "Body#xpath=//*[@id='Body']";
        public static String Communication_viewCustom_Body = "Body#xpath=//*[@id='Body']";

        public static String Communication_View_Name_Label = "NameLabel#xpath=//*[text()='Name']";
        public static String Communication_View_Name = "Name#xpath=//*[@formcontrolname='name']";
        public static String Communication_View_communicationType_Label = "communicationTypeLabel#xpath=//*[text()='Type']";
        public static String Communication_View_communicationType = "communicationType#xpath=//*[@formcontrolname='Type']";
        public static String Communication_View_Subject_Label = "SubjectLabel#xpath=//*[text()='Subject']";
        public static String Communication_View_Subject = "Subject#xpath=//*[@formcontrolname='Subject']";
        public static String Communication_View_Description_Label = "DescriptionLabel#xpath=//*[text()='Description']";
        public static String Communication_View_Description = "Description#xpath=//*[@formcontrolname='Description']";
        public static String Communication_View_Body_Label = "BodyLabel#xpath=//*[text()='Body']";
        public static String Communication_View_Body = "Body#xpath=//*[@formcontrolname='Body']";
        public static String Communication_Delete_Confirm = "DeleteSucess#xpath=//*[text()='Communication deleted successfully.']";
        public static String Communication_validation = "validation#xpath=//*[text()='Please provide required values.']";
        public static String Communication_Edit_SucessValidation = "Edit_SucessValidation#xpath=//*[text()='Communication updated successfully']";


        // Security
        public static String Security_BlackListtab = "BlackList#xpath=//*[@href='#blacklistTab']";
        public static String Security_whitelistTab = "whitelistTab#xpath=//*[@href='#whitelistTab']";
        public static String Security_userTab = "userTab#xpath=//*[@href='#userTab']";
        public static String Security_DisplayColumn = "DisplayColumn#xpath=//*[contains(text(),'Display Columns')]";
        public static String Security_DisplayColumn_UserId = "UserId#xpath=//*[text()='UserId']";
        public static String Security_DisplayColumn_Timestamp = "Timestamp#xpath=//*[text()='Timestamp']";
        public static String Security_DisplayColumn_SelectAll_Btn = "Btn_SelectAll#xpath=//*[contains(text(),'Select all')]";
        public static String Security_DisplayColumn_Selectnone_Btn = "Btn_Selectnone#xpath=//*[contains(text(),'Select none')]";
        public static String Security_Unlock_UserName_Label = "label_UserName#xpath=//*[@for='userName']";
        public static String Security_Unlock_UserName = "UserName#xpath=//*[@id='userName']";
        public static String Security_Unlock_Unlock_Btn = "Btn_Unlock#xpath=//*[@value='Unlock Account']";

        // Common
        public static String Deleteicon = "Deleteicon#xpath=//*[@class='deleteButton']";
        public static String Save_Btnorganization = "SaveBtn#xpath=//*[@value='Save Changes']";
        public static String UserUpdateSave_Btn = "SaveBtn#xpath=(//*[@value='Save Changes'])[1]";
        public static String Cancel_Btn = "CancelBtn#xpath=//*[@value='Cancel']";
        public static String Create_Btn = "CreateBtn#xpath=//*[@value='Create']";
        public static String AddBtn = "Add#xpath=//*[@id='MainContent_RoleGrid_btnNewRole']";
        public static String Delete_ValidationMSg_Confirm = "DeleteValidationMSg_Confirm#xpath=//*[text()='Confirm']";
        public static String Delete_ValidationMSg = "DeleteValidationMSg#xpath=//*[text()='Are you sure you want to delete this entry?']";
        public static String Yes = "btnYes#xpath=//button[text()='Yes']";
        public static String NO  = "btnNO#xpath=//button[text()='No']";
        public static String AlertSucess = "AlertSucess#xpath=//*[@class='alert alert-success']";
        public static String AlertDanger = "AlertFail#xpath=//*[@class='alert alert-danger']";
        public static String MandatoryField = "MandatoryField#xpath=//*[@class='help-block']";
        public static String PlusIcon = "PlusIcon#xpath=//*[text()='+']";
        public static String Pagination = "Pagination#xpath=//*[@class='pagination']";
        public static String ActivePagination = "ActivePagination#xpath=//*[@class='pagination']//*[@class='active']/a";
        public static String ActivePaginationNext = "ActivePaginationNext#xpath=//*[@class='pagination']//a[text()='2']";
        //public static String ActivePaginationNext = "PageList#xpath=//select";

        public static String Mailinator_Inputbox = "Inputbox#xpath=//*[@id='inboxfield']";
        public static String Mailinator_Inputbox_GoBtn = "GoBtn#xpath=//*[@class='input-group-btn']/button";
        public static String Mailinator_ActivationMail = "ActivationMail#xpath=(//*[text()='ionicTemplate Account Activation'])[1]";
        public static String Mailinator_Mail_ActivateBtn = "ActivateBtn#xpath=//a";
        public static String Mailinator_ForgotPasswordMail = "ForgotPasswordMail#xpath=(//*[text()='ionicTemplate Password Reset'])[1]";
        public static String Mailinator_ForgotPassword_reset = "ResetBtn#xpath=//*[text()='Reset']";
        public static String Mailinator_ForgotPassword_Sucess = "ForgotPassword_Sucess#xpath=//h1[text()='Your password has been reset.']";
    }
}




