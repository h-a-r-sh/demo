import UserInfo from "./user/userinfo";
import Useraddress from "./user/useraddress";
function User(){
    return(
        <div className="container">
            <h1>Hello its a user</h1>
            <UserInfo></UserInfo>
            <Useraddress></Useraddress>
        </div>
        
    )
}
export default User;