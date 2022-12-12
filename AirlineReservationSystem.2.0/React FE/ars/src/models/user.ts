export interface User{
    email: string,
    role : string,
    name: string,
    jwtToken: string, 
    refreshToken: string,
    jwtTokenExpiration: string,
    refreshTokenExpiration: string, 
}