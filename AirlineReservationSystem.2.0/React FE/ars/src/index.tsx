import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";

import {store} from "./store/configureStore";
import { Provider } from "react-redux";

console.log(store.getState())

const root = ReactDOM.createRoot(document.getElementById("root") as HTMLElement);
root.render(
  <React.StrictMode>
    <Provider store={store}>
    <App />
    </Provider>
  </React.StrictMode>
);
