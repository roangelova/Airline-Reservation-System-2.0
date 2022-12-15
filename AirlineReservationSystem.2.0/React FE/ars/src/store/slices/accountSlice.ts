import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import { User } from "models/user";
import agent from "agent";

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
    logout: (data) => {
      //stg
    }
  },
  extraReducers: (builder => {
    builder.addCase(loginUser.rejected, (state) => {
      console.log('Failed to log in user');
    });
    builder.addCase(loginUser.fulfilled, (state) => {
      console.log('Login successful');
    });
  })
}
)

export const loginUser = createAsyncThunk('account/loginUser', async (data: {email: string, password:string}, thunkAPI) => {
  try {
    const result = await agent.Account.login(data.email, data.password);
    return result;
  } catch (error) {
  return thunkAPI.rejectWithValue('Error');
  }
})

export default accountSlice.reducer;

export const {logout} = accountSlice.actions;
