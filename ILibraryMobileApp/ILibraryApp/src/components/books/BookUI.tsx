import {BookViewModel} from "../../models/BookModels";
import {API_IMAGE_PATH} from "../../services/ApiRequest";
import {Image, Text} from "react-native";
import * as React from "react";
import serverStore from "../../stores/ServerStore";

export default class BookUI {
    static getBookProfile(book: BookViewModel) {
        let uri = null;
        if (book.images.length > 0) {
            uri = `${serverStore.IPAddress}${API_IMAGE_PATH}/${book.images[0].fullPath}`;
        }
        let image;
        if (uri != null)
            image = <Image
                style={{width: 100, height: 100}}
                source={{uri: uri}}/>;
        else
            image = <Image
                style={{width: 100, height: 100}}
                source={require('../../../assets/images/no_image.jpg')}/>;
        return image;
    }

    static displayTextIfExist(text: string){
        if (text)
            return <Text>{text}</Text>
    }
}