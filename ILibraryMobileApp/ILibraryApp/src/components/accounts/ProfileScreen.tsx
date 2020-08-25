import { View, StyleSheet, Text, TextInput, ActivityIndicator, ScrollView, TouchableOpacity } from "react-native";
import * as React from "react";
import userStore from "../../stores/UserStore";
import { PrimaryColor } from "../../AppConstant";
import { Button } from "react-native-elements";
import Icon from 'react-native-vector-icons/Feather'
import { inject, observer } from "mobx-react";


interface IProps {
    navigation: any,
    // @ts-ignore
    userStore: UserStore
}

class ProfileScreen extends React.Component<IProps> {

    componentDidMount() {
        this.props.userStore.initializeForm()
    }

    componentWillUnmount() {
        this.props.userStore.initializeForm();
    }

    update = () => {
        this.props.userStore.update();
    };

    render() {
        const { errors, isLoading, updateSuccess } = this.props.userStore;
        const store = this.props.userStore;
        return (
            <>
                <View style={styles.topBar}>
                    <TouchableOpacity
                        onPress={() => {
                            this.props.navigation.goBack();
                        }}
                    >
                        <Icon name="arrow-left" size={22} style={styles.icon} />
                    </TouchableOpacity>

                    <View style={{
                        marginLeft: 20,
                        flexDirection: 'row-reverse',
                        flex: 1
                    }}>
                        <Button
                            onPress={this.update}
                            title='Save changes' />
                        {store.isLoading ?
                            <ActivityIndicator size='large' color={PrimaryColor} />
                            : null}
                    </View>
                </View>


                <ScrollView>
                    <View style={styles.mainView}>
                        {updateSuccess ? <Text>The update was successful.</Text> : null}
                        <View style={styles.rowView}>
                            <Text style={styles.label}>First name</Text>
                            <TextInput
                                style={styles.textField}
                                placeholder='First name'
                                value={store.form.firstName}
                                onChangeText={value => {
                                    this.props.userStore.setFirstName(value)
                                }}
                            />
                            {errors.firstName && errors.firstName.length > 0 ?
                                <Text style={styles.error}>
                                    {errors.firstName[0]}
                                </Text> : null}
                        </View>

                        <View>
                            <Text style={styles.label}>Last name</Text>
                            <TextInput
                                style={styles.textField}
                                placeholder='Last name'
                                value={store.form.lastName}
                                onChangeText={value => {
                                    this.props.userStore.setLastName(value)
                                }}
                            />
                            {errors.lastName && errors.lastName.length > 0 ?
                                <Text style={styles.error}>
                                    {errors.lastName[0]}
                                </Text> : null}
                        </View>

                        <View>
                            <Text style={styles.label}>Email address</Text>
                            <TextInput
                                style={styles.textField}
                                placeholder='Email address'
                                value={store.form.email}
                                onChangeText={value => {
                                    this.props.userStore.setEmail(value)
                                }}
                            />
                            {errors.email && errors.email.length > 0 ?
                                <Text style={styles.error}>
                                    {errors.email[0]}
                                </Text> : null}
                        </View>

                        <View>
                            <Text style={styles.label}>Phone number</Text>
                            <TextInput
                                style={styles.textField}
                                placeholder='Phone number'
                                value={store.form.phone}
                                onChangeText={value => {
                                    this.props.userStore.setPhone(value)
                                }}
                            />
                            {errors.phone && errors.phone.length > 0 ?
                                <Text style={styles.error}>
                                    {errors.phone[0]}
                                </Text> : null}
                        </View>

                        <View>
                            <Text style={styles.label}>Password</Text>
                            <TextInput
                                style={styles.textField}
                                placeholder='Password'
                                secureTextEntry={true}
                                value={store.form.Password}
                                onChangeText={value => {
                                    this.props.userStore.setPassword(value)
                                }}
                            />
                            {errors.phone && errors.password.length > 0 ?
                                <Text style={styles.error}>
                                    {errors.password[0]}
                                </Text> : null}
                        </View>
                    </View>
                </ScrollView>
            </>
        )
    }
}

const styles = StyleSheet.create({
    topBar: {
        flexDirection: 'row',
        borderRadius: 1,
        elevation: 3,
        padding: 10
    },
    searchBox: {

    },
    icon: {
        marginTop: 15,
        marginLeft: 5
    },
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
export default inject('userStore')(observer(ProfileScreen))