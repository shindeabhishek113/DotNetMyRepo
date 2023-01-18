namespace BOL;
public class Roles
{

public int RoleID{get;set;}
public string RoleName{get;set;}

public Roles(){

}

public Roles(int roleid, string rolename ){
    this.RoleID=roleid;
    this.RoleName=rolename;
}

}
