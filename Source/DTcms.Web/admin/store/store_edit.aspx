<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="store_edit.aspx.cs" Inherits="DTcms.Web.admin.store.store_edit" ValidateRequest="false" %>

<%@ Import Namespace="DTcms.Common" %>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width,minimum-scale=1.0,maximum-scale=1.0,initial-scale=1.0,store-scalable=no" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <title>编辑仓库</title>
    <link href="../../scripts/artdialog/ui-dialog.css" rel="stylesheet" type="text/css" />
    <link href="../skin/default/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" charset="utf-8" src="../../scripts/jquery/jquery-1.11.2.min.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../scripts/jquery/Validform_v5.3.2_min.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../scripts/datepicker/WdatePicker.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../scripts/artdialog/dialog-plus-min.js"></script>
    <script type="text/javascript" charset="utf-8" src="../js/laymain.js"></script>
    <script type="text/javascript" charset="utf-8" src="../js/common.js"></script>
    <script type="text/javascript">
        $(function () {
            //初始化表单验证
            $("#form1").initValidform();
        });
</script>
</head>

<body class="mainbody">
    <form id="form1" runat="server">
        <!--导航栏-->
        <div class="location">
            <a href="store_list.aspx" class="back"><i></i><span>返回列表页</span></a>
            <a href="../center.aspx" class="home"><i></i><span>首页</span></a>
            <i class="arrow"></i>
            <a href="store_list.aspx"><span>仓库管理</span></a>
            <i class="arrow"></i>
            <span>编辑仓库</span>
        </div>
        <div class="line10"></div>
        <!--/导航栏-->

        <!--内容-->
        <div id="floatHead" class="content-tab-wrap">
            <div class="content-tab">
                <div class="content-tab-ul-wrap">
                    <ul>
                        <li><a class="selected" href="javascript:;">基本资料</a></li>
                    </ul>
                </div>
            </div>
        </div>

        <div class="tab-content">
            <dl>
                <dt>所属仓库区域</dt>
                <dd>
                    <div class="rule-single-select">
                        <asp:DropDownList ID="ddlStoreDomain" runat="server" datatype="*" errormsg="请选择仓库区域" sucmsg=" "></asp:DropDownList>
                    </div>
                </dd>
            </dl>
            <dl>
                <dt>仓库名称</dt>
                <dd>
                    <asp:TextBox ID="txtName" runat="server" CssClass="input normal" datatype="*2-100" sucmsg=" "></asp:TextBox>
                    <span class="Validform_checktip">*</span></dd>
            </dl>
            <dl>
                <dt>仓库管理</dt>
                <dd>
                    <asp:TextBox ID="txtManager" runat="server" CssClass="input normal"></asp:TextBox></dd>
            </dl>
            <dl>
                <dt>地址</dt>
                <dd>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="input normal"></asp:TextBox></dd>
            </dl>
            <dl>
                <dt>描述说明</dt>
                <dd>
                    <asp:TextBox ID="txtRemark" runat="server" CssClass="input normal" TextMode="MultiLine" />
                    <span class="Validform_checktip">仓库区域的描述说明</span>
                </dd>
            </dl>
        </div>

        <!--/内容-->

        <!--工具栏-->
        <div class="page-footer">
            <div class="btn-wrap">
                <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" OnClick="btnSubmit_Click" />
                <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript: history.back(-1);" />
            </div>
        </div>
        <!--/工具栏-->

    </form>
</body>
</html>
