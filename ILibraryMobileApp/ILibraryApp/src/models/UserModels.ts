export interface UserViewModel{
    id: number,
    firstName: string,
    lastName: string,
    email: string,
    phone: string,
    idNumber: string,
    password: string,
    token: string
}

export interface UserLoginViewModel {
    email: string,
    password: string
}

export interface UserLoginViewModelError {
    error: string;
    email: string[],
    password: string[]
}

export interface UserUpdateViewModelError extends UserLoginViewModelError{
    phone: string[],
    firstName: string[],
    lastName: string[],
    idNumber: string[]
}



export interface UserUpdatePwdViewModel {
    currentPassword: string,
    newPassword: string
}