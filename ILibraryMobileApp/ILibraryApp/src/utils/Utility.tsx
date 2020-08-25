import { Image, Text } from "react-native";
import * as React from "react";

export default class Utility {

    /**
     * Capitalize the first character of a string
     * @param input
     */
    static firstToUppercase = (input: string): string =>
        input ? input.charAt(0).toUpperCase() + input.slice(1) : '';

    static reduceString(str: string): string {
        if (str.length > 16) {
            str = str.substring(0, 14) + "...";
        }
        return str;
    }

    /**
     *
     * @param uri
     * @param width
     * @param height
     */
    static getImage(uri: string, width: number = 100, height: number = 100) {
        if (!uri)
            return (
                <Image
                    style={{ width: width, height: height }}
                    source={require('../../assets/images/no_image.jpg')}
                />
            );

        return (
            <Image
                width={width}
                height={height}
                source={{ uri: uri }}
            />
        )
    }

    static displayTextIfExist(text: string) {
        if (text)
            return <Text numberOfLines={1}>{text}</Text>
    }

    static isValidEmail(email: string) {
        const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        return re.test(email);
    }

    static isValidPhoneNumber(number: string) {
        const re = /^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$/im
        return re.test(number)
    }
}