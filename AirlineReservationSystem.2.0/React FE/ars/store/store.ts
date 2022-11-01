import { configureStore } from "@reduxjs/toolkit";
import { useSelector } from "react-redux";
import { CounterState } from "./reducers/counterReducer";

let someReducer;
export function createStore(){
    return configureStore(someReducer);
    //wraps createStore to provide simplified configuration options and good defaults. It can automatically combine your slice reducers, adds
    // whatever Redux middleware you supply, includes redux-thunk by default, and enables use of the Redux DevTools Extension.
}


//access the store
const {data, title} = useSelector((state: CounterState) => state);