import { createSlice } from "@reduxjs/toolkit";
import { User } from "models/user";

interface AccountState {
    user: User | null;
}

const initialState: AccountState = {
    user: null
}

export const accountSlice = createSlice({
  name: 'account',
  initialState, 
  reducers: {
    logIn: (data) => {
      //do something with this data
    }
  }
})

export const {logIn} = accountSlice.actions;
