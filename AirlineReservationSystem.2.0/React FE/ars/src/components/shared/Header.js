import React from "react"

const Header = () => {
    return (
        <div className="header">
            <div className="logo">
                <img src={require('../../assets/images/homepage/logo.png')} />
            </div>
            <div className="header-nav">
                <div className="header-nav__pages">
                    <ul className="header-nav__options">
                        <li className="header-nav__item">
                            <a href="#">Explore</a>
                        </li>
                        <li className="header-nav__item">
                            <a href="#">Book</a>
                        </li>
                        <li className="header-nav__item">
                            <a href="#">Club card</a>
                        </li>
                    </ul>
                </div>
                <div className="header-nav__user">
                    <ul className="header-nav__options">
                        <li className="header-nav__item">
                            <a href="#">Login</a>
                        </li>
                        <li className="header-nav__item">
                            <a href="#">Register</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div >
    )
}


export default Header;