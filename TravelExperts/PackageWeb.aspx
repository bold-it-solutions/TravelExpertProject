<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PackageWeb.aspx.cs" Inherits="TravelExperts.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PackageId" DataSourceID="ObjectDataSource1" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="PackageId" HeaderText="Id" SortExpression="PackageId" />
            <asp:BoundField DataField="PkgName" HeaderText="Name" SortExpression="PkgName" />
            <asp:BoundField DataField="PkgStartDate" HeaderText="Start Date" SortExpression="PkgStartDate" />
            <asp:BoundField DataField="PkgEndDate" HeaderText="End Date" SortExpression="PkgEndDate" />
            <asp:BoundField DataField="PkgDesc" HeaderText="Desc" SortExpression="PkgDesc" />
            <asp:BoundField DataField="PkgBasePrice" HeaderText="Base Price" SortExpression="PkgBasePrice" />
            <asp:BoundField DataField="PkgAgencyCommission" HeaderText="Commission" SortExpression="PkgAgencyCommission" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" DeleteText="Delete |" EditText="Edit | " ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DataObjectTypeName="Data.Package" DeleteMethod="DeletePackage" 
        InsertMethod="AddPackage" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllPackage" TypeName="Data.PackageDB" 
        UpdateMethod="UpdatePackage" ConflictDetection="CompareAllValues">
<%--        OnDeleted="ObjectDataSource1_GetAffectedRows" 
        OnUpdated="ObjectDataSource1_GetAffectedRows">--%>
        <UpdateParameters>
            <asp:Parameter Name="original_Package" Type="Object" ></asp:Parameter>
            <asp:Parameter Name="package" Type="Object" ></asp:Parameter>
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource2" Height="50px" Width="285px">
        <Fields>
            <asp:BoundField DataField="PackageId" HeaderText="Id" SortExpression="PackageId" />
            <asp:BoundField DataField="PkgName" HeaderText="Name" SortExpression="PkgName" />
            <asp:BoundField ApplyFormatInEditMode="True" DataField="PkgStartDate" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Start Date(mm/dd/yyyy)" SortExpression="Start Date" />
            <asp:BoundField ApplyFormatInEditMode="True" DataField="PkgEndDate" DataFormatString="{0:MM/dd/yyyy}" HeaderText="End Date(mm/dd/yyyy)" SortExpression="PkgEndDate" />
            <asp:BoundField DataField="PkgDesc" HeaderText="Desc" SortExpression="PkgDesc" />
            <asp:BoundField DataField="PkgBasePrice" HeaderText="BasePrice" SortExpression="PkgBasePrice" />
            <asp:BoundField DataField="PkgAgencyCommission" HeaderText="Commission" SortExpression="PkgAgencyCommission" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="Data.Package" InsertMethod="AddPackage" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackageByID" TypeName="Data.PackageDB">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="1" Name="packageID" SessionField="PackageID" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>


