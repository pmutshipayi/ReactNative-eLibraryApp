import React from "react";
import { Text, View, TouchableOpacity, ScrollView, RefreshControl, StyleSheet } from "react-native";
import { LibraryViewModel } from "../../models/LibraryModels";
import LibraryService from "../../services/LibraryService";
import Icon from 'react-native-vector-icons/Feather'
import { Divider } from "react-native-elements";
import Utility from "../../utils/Utility";
import { NavigationStackProp } from "react-navigation-stack";


interface IProps {
    navigation: NavigationStackProp
}

interface IState {
    isLoading: boolean;
    libraries: LibraryViewModel[]
}

export default class LibraryScreen extends React.Component<IProps, IState> {

    constructor(props: IProps) {
        super(props);
        this.state = {
            isLoading: false,
            libraries: []
        }
    }

    componentDidMount() {
        this.loadLibraries();
    }

    loadLibraries = () => {
        if (this.state.isLoading) return;
        this.setState({ isLoading: true });
        LibraryService.loadLibraries()
            .then((result) => {
                this.setState({ libraries: result.data });
                console.log(this.state.libraries.length)
            })
            .catch((err) => {
                // and error occured
                console.log("err : " + err)
            })
            .finally(() => {
                this.setState({ isLoading: false });
            })
    }

    render() {
        return (
            <ScrollView
                style={styles.scrollView}
                refreshControl={
                    <RefreshControl
                        refreshing={this.state.isLoading}
                        onRefresh={() => this.loadLibraries()}
                    />
                }
            >
                {this.state.libraries.map((item) =>
                    <TouchableOpacity
                        style={styles.name}
                        onPress={() => {
                            this.props.navigation.push("LibraryDetail", {
                                library: item
                            })
                        }}>
                        <Text style={styles.name}>
                            {Utility.firstToUppercase(item.name)}
                        </Text>
                        {item.address ?
                            <View style={styles.infoView}>
                                <Icon name="map-pin" size={15} />
                                <Text style={styles.address}>{item.address}</Text>
                            </View> : null}
                        <Divider />
                    </TouchableOpacity>
                )}
            </ScrollView>
        )
    }
}

const styles = StyleSheet.create({
    scrollView: {
        width: '80%'
    },
    main: {
        padding: 10,
        height: 100
    },
    name: {
        fontSize: 18,
        fontWeight: 'bold',
        marginLeft: 10,
        marginTop: 5
    },
    infoView: {
        flexDirection: 'row',
        padding: 5,
        marginTop: 5,
        marginLeft: 5
    },
    address: {
        marginLeft: 5,
        fontSize: 13
    }
});
