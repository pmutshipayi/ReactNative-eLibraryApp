import * as React from "react";
import { View, Text, TextInput, TouchableOpacity, StyleSheet, ActivityIndicator } from "react-native";
import { inject, observer } from "mobx-react";
import { Button, Divider } from "react-native-elements";
import { PrimaryColor } from "../../AppConstant";
import authStore from "../../stores/AuthStore";
import { NavigationStackProp } from "react-navigation-stack";
import { NavigationActions } from "react-navigation";
import { action } from "mobx";
import { AxiosError } from "axios";
import { UserLoginViewModelError } from "../../models/UserModels";

interface IProps {
    navigation: NavigationStackProp,
    // @ts-ignore
    authStore: AuthStore
}


class LoginScreen extends React.Component<IProps> {

    constructor(props: IProps) {
        super(props);
    }

    componentWillUnmount() {
        this.props.authStore.setPassword('');
        this.props.authStore.setEmail('');
    }

    signIn = () => {
        const login = this.props.authStore.login();
        if (login === undefined) return;

        login.then(action(async (response: any) => {
            await authStore.handleAuthAsync(response);
            this.props.navigation.navigate("Home")
        })).catch(action((err: any) => {
            const result = err as AxiosError<UserLoginViewModelError>;
            // this.errors = result.response!.data;
            this.props.authStore.setErrors(result.response!.data);
        })).finally(action(() => {
            // this.isLoading = false;
            this.props.authStore.setLoading(false);
        }));
    };

    render() {
        const { errors, isAuthenticated } = this.props.authStore;
        /* if (isAuthenticated)
            this.props.navigation.navigate('Home');*/

        return (
            <View style={styles.mainView}>
                <View style={styles.rowView}>
                    <Text style={styles.label}>Email address</Text>
                    <TextInput
                        style={styles.textField}
                        placeholder='Username'
                        onChangeText={value => {
                            this.props.authStore.setEmail(value)
                        }}
                    />
                    {errors.email && errors.email.length > 0 ?
                        <Text style={styles.error}>
                            {this.props.authStore.errors.email[0]}
                        </Text> : null}
                </View>
                <View style={styles.rowView}>
                    <Text style={styles.label}>Password</Text>
                    <TextInput
                        style={styles.textField}
                        secureTextEntry={true}
                        placeholder='Password'
                        onChangeText={value => {
                            this.props.authStore.setPassword(value);
                        }}
                    />
                    {errors.password && errors.password.length > 0 ?
                        <Text style={styles.error}>
                            {this.props.authStore.errors.password[0]}
                        </Text> : null}
                </View>
                <View style={{ flexDirection: 'row-reverse' }}>
                    {authStore.isLoading ?
                        <ActivityIndicator size='large' color={PrimaryColor} />
                        : null}
                    <Button
                        style={{ marginTop: 10 }}
                        onPress={this.signIn}
                        title='Sign in' />
                </View>
                <Divider />
                <View style={{ flexDirection: 'row', marginTop: 10 }}>
                    <Text style={styles.label}>If you don't have an account ? then </Text>
                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('SignUp')}
                    >
                        <Text style={{ textDecorationLine: 'underline' }}>Sign up</Text>
                    </TouchableOpacity>
                </View>
                <TouchableOpacity
                    onPress={() => {
                        this.props.navigation.push("SConfig", {});
                        console.log("show server");
                    }}
                >
                    <Text style={{ textDecorationLine: 'underline' }}>Set server IP address</Text>
                </TouchableOpacity>
            </View>
        )
    }
}

export default inject('authStore')(observer(LoginScreen));

const styles = StyleSheet.create({
    mainView: {
        flex: 1,
        alignItems: 'center',
        marginTop: 25
    },
    textField: {
        width: 250,
        borderColor: '#d6d7da',
        borderWidth: 1,
        marginTop: 10
    },
    rowView: {
        padding: 3
    },
    label: {
        fontWeight: 'bold',
        fontSize: 15
    },
    error: {
        color: 'red'
    }
});