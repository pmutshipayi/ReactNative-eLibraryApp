import React from "react";
import { View, Text } from "react-native";

interface IProps {
    text: string
}

export default class NoResult extends React.Component<IProps> {

    render() {
        return (
            <View>
                <Text>
                    No result for {this.props.text}
                </Text>
            </View>
        )
    }

}