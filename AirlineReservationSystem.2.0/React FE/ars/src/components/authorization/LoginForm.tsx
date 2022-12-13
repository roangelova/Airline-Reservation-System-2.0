import React, { useState } from 'react';

const LoginForm: React.FC = () => {

    const [data, setData] = useState({email : '', password: ''})

    const onLoginSubmitHandler = async (e: React.FormEvent) => {
        e.preventDefault();
      
    }

    const onChangeHandler = (e: any) => {
        setData({
            ...data,
            [e.target.name]: e.target.value
        })
    }

    return (
        <section className="login">
            <div className='login--wrapper'>
                <div className="login__content">
                    <div className='login__logobox'>
                        <img src={require('../../assets/images/LOGO.png')} alt="App logo" />
                    </div>
                    <h1 className='heading-primary margin-bottom-small'>Welcome back</h1>
                    <h3 className='heading-tertiary margin-bottom-small'>The faster you fill this form up, the faster you can start booking</h3>
                    <form className='login__form' onSubmit={onLoginSubmitHandler}>
                        <div className='login__form--email margin-bottom-small'>
                            <label
                                className='login__form-label'
                                htmlFor="email">
                                Email
                            </label>
                            <input
                                className='login__form-input'
                                id="email"
                                name="email"
                                onChange={onChangeHandler}
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--password margin-bottom-medium'>
                            <label
                                className='label login__form-label'
                                htmlFor="password">
                                Password
                            </label>
                            <input
                                className='input login__form-input'
                                id="password"
                                type="password"
                                name="password"
                                onChange={onChangeHandler}
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--controls margin-bottom-small'>
                            <a className="btn login__btn" href="#">Sign in</a>
                        </div>
                        <div className='login--signUp'>
                            <span>Don't have an account ? <a href="">Sign up now!</a></span>
                        </div>
                    </form>
                </div>
                <div className="login__image">
                </div>
            </div>
        </section>
    )
}

export default LoginForm;