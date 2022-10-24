import axios from "axios";

axios.defaults.baseURL = 'https://localhost:7078/api/';

const responseBody = (response) => response.data;

axios.interceptors.response.use(response => {
    return response;
}, (error) => {
    const { data, status } = error.response;
    switch (status) {
        //add UI notifications
        case 400:
            if (data.errors) {
                const modelStateErrors = [];
                for (const key in data.errors) {
                    modelStateErrors.push(data.errors[key]);
                }
                throw modelStateErrors.flat();
            }
            case 500:
            //history.push({pathname: '/server-error-component', state: {error: data})
            //....
            break;
    }
    return Promise.reject(error.response);
})

export const agent = {
    get: (url) => axios.get(url).then(responseBody),
    post: (url, body) => axios.post(url, body).then(responseBody),
    put: (url, body) => axios.put(url, body).then(responseBody),
    delete: (url) => axios.delete(url).then(responseBody)
}