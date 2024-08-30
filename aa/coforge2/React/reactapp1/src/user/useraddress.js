function UserAddress(){
    return(
        <div>
            <h2>Address</h2>
            <table className="table table-bordered table-stripped">
                <thead>
                    <tr>
                        <th>Address Id</th>
                        <th>Address City</th>
                        <th>Address Location</th>
                        <th>Address State</th>
                    </tr>
                    <tr>
                        <td>{useraddress[0].addrid}</td>
                        <td>{useraddress[0].addrid}</td>
                        <td>{useraddress[0].addrid}</td>
                        <td>{useraddress[0].addrid}</td>
                    </tr>
                </thead>
                <tbody>

                </tbody>
            </table>
        </div>
        
    )
}
export default UserAddress;
const useraddress=[
    {"addrid":1, "city":"greater noida", "location":"sector1", "state":"up"},
    {"addrid":2, "city":"gurgaon", "location":"sector1", "state":"haryana"},
    {"addrid":3, "city":"chandigarh", "location":"sector1", "state":"punjab"},
]