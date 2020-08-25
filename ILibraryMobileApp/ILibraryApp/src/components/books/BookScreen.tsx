import {
    StyleSheet,
    View,
    ActivityIndicator,
    RefreshControl
}
    from "react-native";
import * as React from "react";
import { FlatGrid } from "react-native-super-grid";
import { BookSearchModel, BookViewModel } from "../../models/BookModels";
import { PrimaryColor } from "../../AppConstant";
import { BookService } from "../../services/BookService";
import BookCard from "./BookCard";
import { TouchableOpacity } from "react-native-gesture-handler";
import Icon from 'react-native-vector-icons/Feather'


interface Props {
    navigation?: any;
}

interface IState {
    isLoading: boolean;
    books: BookViewModel[]
    error: string
}

class BookScreen extends React.Component<Props, IState> {

    // @ts-ignore
    static navigationOptions = ({ navigation }) => ({
        title: navigation.getParam('title', 'Books'),
        headerRight: (
            <TouchableOpacity
                style={{ marginLeft: -1 }}
                onPress={() => {
                    navigation.push("BookSearch")
                }}
            >
                <Icon name="search" size={25} color="gray" />
            </TouchableOpacity>
        )
    });

    searchModel: BookSearchModel = {};

    constructor(props: Props) {
        super(props);
        this.state = {
            isLoading: false,
            error: '',
            books: []
        };
    }

    componentDidMount() {
        this.loadBooks();
    }

    loadBooks = () => {
        const { navigation } = this.props;
        if (navigation)
            this.searchModel = navigation.getParam("searchModel", null);

        this.setState({ isLoading: true });
        BookService.getBooks(this.searchModel)
            .then((result) => {
                this.setState({ books: result.data });
            })
            .catch((err) => {
                // There error goes here.
            })
            .finally(() => {
                this.setState({ isLoading: false });
                console.log("finally")
            });
    };

    render() {
        const books = this.state.books;
        let content;
        if (this.state.isLoading)
            content = (
                <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
                    <ActivityIndicator size='large' color={PrimaryColor} />
                </View>
            );
        else {
            content = (
                <FlatGrid
                    itemDimension={100}
                    items={books}
                    style={styles.gridView}
                    refreshControl={
                        <RefreshControl
                            refreshing={this.state.isLoading}
                            onRefresh={() =>
                                this.loadBooks()
                            }
                        />
                    }
                    renderItem={({ item, index }) => (
                        <BookCard book={item} navigation={this.props.navigation} />
                    )}
                />
            );
        }
        return (
            content
        );
    }
}

const styles = StyleSheet.create({
    gridView: {
        marginTop: 20,
        flex: 1
    },
    itemContainer: {
        justifyContent: 'flex-end',
        borderRadius: 5,
        padding: 10,
        height: 130
    },
    itemName: {
        fontSize: 13,
        color: 'black',
        fontWeight: '600',
    },
    itemCode: {
        fontWeight: '600',
        fontSize: 10,
        color: '#000',
    },
    imageBackground: {
        width: '100%',
        height: '100%',
        borderRadius: 10,
    }
});
export default BookScreen;
//export default observer(BookScreen);
//export default inject("bookStore")(observer(BookScreen))