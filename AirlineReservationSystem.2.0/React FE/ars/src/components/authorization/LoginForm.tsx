import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { loginUser } from 'store/slices/accountSlice';
import { useAppDispatch } from 'store/configureStore';

function LoginForm() {

    const dispatch = useAppDispatch()

    const [data, setData] = useState<{email:string; password:string}>({email: '', password:  ''});

    const onLoginSubmitHandler = async (e: React.FormEvent) => {
        e.preventDefault();
        console.log(data);

        dispatch(loginUser(data));

        setData({ email: '', password: '' });
    };

    const onChangeHandler = (e: any) => {
        setData({
            ...data,
            [e.target.name]: e.target.value.trim()
        });
    };

    return (
        <section className="login">
            <div className='login--wrapper'>
                <div className="login__content">
                    <div className='login__logobox'>
                        <img src={require('../../assets/images/LOGO.png')} alt="App logo" />
                    </div>
                    <h1 className='heading-primary margin-bottom-small'>Welcome back</h1>
                    <h3 className='heading-tertiary margin-bottom-small'>Ready to book your next holiday? Sign in now!</h3>
                    <form className='login__form'>
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
                                placeholder='example@gmail.com'
                                value={data.email}
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
                                placeholder='MyPassword'
                                value={data.password}
                                onChange={onChangeHandler}
                                required
                            >
                            </input>
                        </div>
                        <div className='margin-bottom-small'>
                            <a onClick={onLoginSubmitHandler} className="btn login__btn" href="#">Sign in</a>
                        </div>
                        <div className='login__signUp'>
                            <Link className='login__signUp--text' to="/register">Don't have an account? Sign up <strong>now</strong> !</Link>
                        </div>
                    </form>
                </div>
                <div className="login__image">
                </div>
            </div>
        </section>
    );
}

export default LoginForm;