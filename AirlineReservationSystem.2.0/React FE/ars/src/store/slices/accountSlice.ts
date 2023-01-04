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
    builder.addCase(loginUser.fulfilled, (state, action) => {
      console.log('Login successful');
      state.user = action.payload;
    });
  })
}
)

export const loginUser = createAsyncThunk('account/loginUser', async (data: { email: string, password: string }, thunkAPI) => {
  try {
    const result = await agent.Account.login(data.email, data.password);
    return result;
  } catch (error) {
    console.log(error)
    return thunkAPI.rejectWithValue('Error');
  }
})

export const registerUser = createAsyncThunk('account/registerUser', async (data:
  {
    email: string,
    username: string,
    firstName: string,
    lastName: string,
    nationality: string,
    password: string,
  }, thunkAPI) => {
  try {
    const result = await agent.Account.register(data.email, data.username,  data.firstName, data.lastName, data.nationality, data.password);
    return result;
  } catch (error) {
    console.log(error)
    return thunkAPI.rejectWithValue('Error');
  }
})


//export default accountSlice.reducer;

export const { logout } = accountSlice.actions;
