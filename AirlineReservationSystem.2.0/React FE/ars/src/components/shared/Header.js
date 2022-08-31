import React from "react"

const Header = () => {
    return (
        <div className="cutomGradient">
        <div className="ui large secondary pointing menu ">
            <a className="toc item">
                <i className="plane icon" ></i>
            </a>
            <a className="active item">Home</a>
            <a className="item">Explore</a>
            <a className="item">Book</a>
            <a className="item">Privilege Club</a>
            <div className="right item">
                <a className="ui inverted button">Log in</a>
                <a className="ui inverted button">Sign Up</a>
            </div>
        </div>
        </div>
    )
}


export default Header;