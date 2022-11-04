import React from "react";

const AdminLayout = () => {

    return (
        <div className="admin">
            <section className="adminNav-block">
            <img src={require('../../assets/images/LOGO.png')} alt="App logo" />
                <div className="adminNav-user">
                    <img src={require('../../assets/images/admin.jpg')} alt="Admin avatar" />
                    <div className="adminNav-userData">
                        <span><strong>Julia Ostin</strong></span>
                        <span>Admin</span>
                    </div>
                </div>
                <div className="adminNav">
                    <ul className="adminNav-list">
                        <li className="adminNav-list--item">Flights</li>
                        <li className="adminNav-list--item">Routes</li>
                        <li className="adminNav-list--item">Fleet</li>
                        <li className="adminNav-list--item">Crew</li>
                    </ul>
                </div>
            </section>
            <section className="adminMain">

            </section>
        </div >
    )
}

export default AdminLayout;