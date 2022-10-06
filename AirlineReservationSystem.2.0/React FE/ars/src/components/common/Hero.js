import React from "react";

const Hero = () => {

    return (
        <section className="section-hero">
            <div className="section-hero-main">
            <div className="section-hero__text-content">
                <h1 className="heading-pr">Airline reservation system</h1>
                <div className="section-hero__reasons">
                    <h2 className="heading-secondary">Why choose us?</h2>
                    <ul className="section-cta__reasons-list">
                        <li className="section-cta__reason">Fast and cheep</li>
                        <li className="section-cta__reason">Variety of options</li>
                        <li className="section-cta__reason">All airlines and offers at 1 place</li>
                    </ul>
                    <div className="section-hero__cta">
                        <a className="btn section-hero__btn">Book now!</a>
                    </div>
                </div>


            </div>
            <div className="section-hero__images">
                <img className="hero-img" src={require('../../assets/images/homepage/hero-2.jpg')} alt="img"></img>
            </div>
            </div>
        </section>
    )
}

export default Hero;