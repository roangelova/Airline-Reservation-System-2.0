import axios, { AxiosResponse } from 'axios';
import store from './store/configureStore';

axios.defaults.baseURL = process.env.REACT_APP_LocalHostUrl;
console.log(axios.defaults.baseURL)

//TODO - solve issue with cirucal dependency with the inteceptor
//TODO -> api routes should be constants
//TODO -> make sure axios returns errors [] messages


//axios.interceptors.request.use(config => {
//   const jwtToken = store.getState().account.user?.jwtToken;
//  // TODO: check if still valid 
//   if (jwtToken) {
//       config.headers!.Authorization = 'Bearer ' + jwtToken;
//   }
//   return config;
//})

axios.interceptors.response.use( 
    response => response,
    error => {
     
        console.log('this is an axios error!', error.message)
    });

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
    get: (url: string, body: {}) => axios.get(url, body).then(responseBody),
    post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
    put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody)
}

const Account = {
    login: (email: string, password: string) =>
        requests.post('authenticate/login',
            {
                email: email,
                password: password
            }
        ),
    register: (email: string, username: string, firstName: string, lastName: string, nationality: string | null, gender: string, password: string) =>
        requests.post('user/registeruserasync', {
            email: email,
            username: username,
            firstName: firstName,
            lastName: lastName,
            nationality: nationality,
            gender :gender,
            password: password
        })
}

const agent = {
    Account
}

export default agent;