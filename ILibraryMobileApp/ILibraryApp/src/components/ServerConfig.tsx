import React from "react";
import { View, Text } from "react-native";
import serverStore from "../stores/ServerStore";
import { TextInput } from "react-native-gesture-handler";
import { Button } from 'react-native-elements'


interface IProps {

}

interface IState {
    ipAddress: string;
    isDone: boolean;
}

export default class ServerComponent extends React.Component<IProps, IState> {

    constructor(props: IProps) {
        super(props);
        this.state = {
            ipAddress: serverStore.IPAddress,
            isDone: false
        }
    }

    changeIpAddress = (value: string) => {
        this.setState({ ipAddress: value })
    }

    render() {
        return (
            <View style={{ marginTop: 20, alignItems: 'center', justifyContent: 'center' }}>
                <Text style={{color: 'green'}}>
                    {this.state.isDone ? "The Server IP address has been set." : ""}
                </Text>
                <TextInput
                    style={{ borderWidth: 1, marginTop: 20, borderColor: 'gray', width: '60%' }}
                    value={this.state.ipAddress}
                    onChangeText={value => this.changeIpAddress(value)}
                />
                <View style={{ marginTop: 10 }}></View>
                <Button
                    title="Save"
                    onPress={() => {
                        serverStore.setIPaddress(this.state.ipAddress);
                        this.setState({isDone: true});
                    }}
                />
            </View>
        )
    }

}