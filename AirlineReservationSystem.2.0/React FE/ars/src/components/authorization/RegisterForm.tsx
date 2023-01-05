import React, { useState } from 'react';
import { Link, redirect } from 'react-router-dom';

import { registerUser } from 'store/slices/accountSlice';

import { useAppDispatch } from 'store/configureStore';

// TODO -> add a "why we require this information" next to the nationality field -> use css after 
//TODO: REDESIGN -> design does not suit the number of fields we have

let Gender = {
    'Male': 1,
    'Female': 2,
    'Other': 3
}

let initialDataState = {
    email: '',
    username: '',
    firstName: '',
    lastName: '',
    nationality: '',
    gender: '',
    password: '',
    confirmPassword: ''
};

const RegisterForm: React.FC = () => {

    const dispatch = useAppDispatch()

    const onRegisterSubmitHandler = async (e: React.FormEvent) => {
        e.preventDefault();

        if (data.confirmPassword !== data.password) {
            alert('Password and confirm password must match!');
            return;
        }

        dispatch(registerUser(data))
            .then(result => {
                if (result.meta.requestStatus === 'fulfilled') {
                    setData(initialDataState);
                }else{
                    redirect('/');
                }
            })
    };

    const [data, setData] = useState<{
        email: string;
        username: string;
        firstName: string;
        lastName: string;
        nationality: string;
        gender: string;
        password: string;
        confirmPassword: string
    }
    >(initialDataState);

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
                    <h1 className='heading-primary margin-bottom-small'>Register now</h1>
                    <h3 className='heading-tertiary margin-bottom-small'>Ready to book your next holiday? Sign up now!</h3>
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
                                onChange={onChangeHandler}
                                name="email"
                                placeholder='example@gmail.com'
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--email margin-bottom-small'>
                            <label
                                className='login__form-label'
                                htmlFor="username">
                                Username
                            </label>
                            <input
                                className='login__form-input'
                                id="username"
                                name="username"
                                onChange={onChangeHandler}
                                placeholder='user123'
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--email margin-bottom-small'>
                            <label
                                className='login__form-label'
                                htmlFor="firstName">
                                First name
                            </label>
                            <input
                                className='login__form-input'
                                id="firstName"
                                name="firstName"
                                onChange={onChangeHandler}
                                placeholder='My first name'
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--email margin-bottom-small'>
                            <label
                                className='login__form-label'
                                htmlFor="lastName">
                                Last name
                            </label>
                            <input
                                className='login__form-input'
                                id="lastName"
                                name="lastName"
                                onChange={onChangeHandler}
                                placeholder='My last name'
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--email margin-bottom-small'>
                            <label
                                className='login__form-label'
                                htmlFor="nationality">
                                Nationality
                            </label>
                            <input
                                className='login__form-input'
                                id="nationality"
                                name="nationality"
                                onChange={onChangeHandler}
                                placeholder='Bulgarian'
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--email margin-bottom-small'>
                            <label
                                className='login__form-label'
                                htmlFor="gender">
                                Gender
                            </label>
                            <select
                                className='login__form-input'
                                id="gender"
                                name="gender"
                                value={data.gender}
                                onChange={onChangeHandler} >
                                {Object.entries(Gender).map(gender => (
                                    <option key={gender[1]} value={gender[0]}>
                                        {gender[0]}
                                    </option>
                                ))}
                            </select>
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
                                onChange={onChangeHandler}
                                name="password"
                                placeholder='MyPassword'
                                required
                            >
                            </input>
                        </div>
                        <div className='login__form--password margin-bottom-medium'>
                            <label
                                className='label login__form-label'
                                htmlFor="confirmPassword">
                                Confirm password
                            </label>
                            <input
                                className='input login__form-input'
                                id="confirmPassword"
                                onChange={onChangeHandler}
                                name="confirmPassword"
                                type="password"
                            >
                            </input>
                        </div>
                        <div className='margin-bottom-small'>
                            <a onClick={onRegisterSubmitHandler} className="btn login__btn" href="#">Register</a>
                        </div>
                        <div className='login__signUp'>
                            <Link className='login__signUp--text' to="/login">Already have an account? Sign in <strong>now</strong> !</Link>
                        </div>
                    </form>
                </div>
                <div className="login__image">
                </div>
            </div>
        </section>
    )
}

export default RegisterForm;