import React from "react";
import { Form, Checkbox, Button} from "semantic-ui-react";

const RegisterForm = () => {

    const options = [
        { key: 'm', text: 'Male', value: 'male' },
        { key: 'f', text: 'Female', value: 'female' },
        { key: 'o', text: 'Other', value: 'other' },
      ]

    return (
        <Form className="registerForm">
    <Form.Field>
      <label>First Name</label>
      <input placeholder='First Name' />
    </Form.Field>
    <Form.Field>
      <label>Last Name</label>
      <input placeholder='Last Name' />
    </Form.Field>
    <Form.Select
            fluid
            label='Gender'
            options={options}
            placeholder='Gender'
          />
    <Form.Field>
    <Form.Field>
      <label>Email</label>
      <input />
    </Form.Field>
    <Form.Field>
      <label>Nationality</label>
      <input />
    </Form.Field>
    <Form.Field>
      <label>Password</label>
      <input type='password' />
    </Form.Field>
    <Form.Field>
      <label>Confirm Password</label>
      <input type='password' />
    </Form.Field>
      <Checkbox label='I agree to the Terms and Conditions' />
    </Form.Field>
    <Button type='submit'>Submit</Button>
  </Form>
    )
}

export default RegisterForm;