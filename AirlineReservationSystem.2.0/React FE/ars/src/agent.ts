import axios, { AxiosResponse } from 'axios';
import store from './store/configureStore';

axios.defaults.baseURL = process.env.REACT_APP_LocalHostUrl;
console.log(axios.defaults.baseURL)

//axios.interceptors.request.use(config => {
//   const jwtToken = store.getState().account.user?.jwtToken;
//  // TODO: check if still valid 
//   if (jwtToken) {
//       config.headers!.Authorization = 'Bearer ' + jwtToken;
//   }
//   return config;
//})

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
        )
}

const agent = {
    Account
}

export default agent;