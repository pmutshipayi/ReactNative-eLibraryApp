import * as React from "react";
import {ScrollView, StyleSheet, TouchableOpacity} from "react-native";
import {View, Text} from "react-native";
import {Button, Divider} from "react-native-elements";
import BookUI from "./BookUI";
import Utility from "../../utils/Utility";
import {BookSearchModel, BookTag, BookViewModel} from "../../models/BookModels";
import {LibraryViewModel} from "../../models/LibraryModels";
import {BookService} from "../../services/BookService";
import LibraryProfileCard from "../libraries/LibraryProfileCard";
import BookCard from "./BookCard";
import LibraryCard from "../libraries/LibraryCard";
import {PrimaryColor} from "../../AppConstant";
import {default as MaterialIcon} from  'react-native-vector-icons/MaterialCommunityIcons'

interface Props {
    // @ts-ignore
    navigation: any;
}

interface IState {
    isLoadingSimilarBooks: boolean,
    isLoadingOtherLibrary: boolean,
    similarBooks: BookViewModel[],
    libraries: LibraryViewModel[]
}

export default class BookDetailScreen extends React.Component<Props, IState> {

    // @ts-ignore
    static navigationOptions = ({navigation}) => {
        return {
            title: Utility.firstToUppercase(navigation.getParam("book", "").name)
        }
    };

    pageSizeBookSimilar = 10;
    book: BookViewModel;

    constructor(props: Props) {
        super(props);
        this.state = {
            isLoadingSimilarBooks: false,
            isLoadingOtherLibrary: false,
            similarBooks: [],
            libraries: []
        };
        const {navigation} = this.props;
        this.book = navigation.getParam("book", "");
    }

    componentDidMount() {
        this.loadOtherLibraries();
        this.loadSimilarBooks();
    }

    /**
     * Loading all similar books
     */
    loadSimilarBooks = () => {
        this.setState({isLoadingSimilarBooks: true});
        BookService.getSimilarBooks(this.book.id)
            .then((result: { data: any; }) => {
                this.setState({similarBooks: result.data});
            })
            .catch(() => {
                // An error occurred !
            })
            .finally(() => {
                this.setState({isLoadingSimilarBooks: false})
            })
    };

    /**
     * Loading all libraries having this book
     */
    loadOtherLibraries = () => {
        if (!this.book.barcode)
            return;
        this.setState({isLoadingOtherLibrary: true});
        BookService.getLibraries(this.book.barcode, this.book.library.id)
            .then((result) => {
                this.setState({libraries: result.data})
            })
            .catch((err) => {
                // error!
            })
            .finally(() => {
                this.setState({isLoadingOtherLibrary: false})
            })
    };

    /**
     *
     */
    renderTags() {
        if (this.book.tags === undefined || this.book.tags.length == 0)
            return;
        return (
            <ScrollView
                style={{marginTop: 10}}
                horizontal={true}>
                {this.book.tags.map((tag: BookTag) => {
                    return (
                        <View key={tag.name}>
                            <TouchableOpacity
                                style={styles.tag}
                                onPress={() => {
                                    let searchModel: BookSearchModel = {
                                        tags: tag.name,
                                    };
                                    this.props.navigation.push("Home", {
                                        title: `#${tag.name}`,
                                        searchModel: searchModel
                                    })
                                }}>
                                <Text>
                                    {tag.name}
                                </Text>
                            </TouchableOpacity>
                        </View>
                    )
                })}
            </ScrollView>
        )
    }

    /**
     * Render similar books
     */
    renderSimilarBooks() {
        if (!this.state.similarBooks)
            return;
        if (this.state.similarBooks.length)
            return (
                <View>
                    <View style={{padding: 10}}>
                        <Text style={{fontSize: 18, fontWeight: 'bold'}}>Similar books</Text>
                    </View>
                    <View style={{flexDirection: 'row-reverse', padding: 10}}>
                        <Button
                            style={{marginLeft: -10}}
                            onPress={() => {
                                this.props.navigation.push("Home", {
                                    book: ""
                                })
                            }}
                            title="VIEW MORE"/>
                    </View>
                    <ScrollView
                        horizontal={true}
                    >
                        {this.state.similarBooks.map((e) => {
                            return <BookCard book={e} navigationPush={true} navigation={this.props.navigation}/>
                        })}
                    </ScrollView>
                </View>
            )
    }

    /**
     * Render other libraries having this book
     */
    renderAtOthersLibraries() {
        if (this.state.libraries.length === 0)
            return;
        return (
            <View>
                <View style={{padding: 10}}>
                    <Text style={{fontSize: 18, fontWeight: 'bold'}}>Other libraries having this book</Text>
                </View>
                <View style={{flexDirection: 'row-reverse', padding: 10}}>
                    <Button
                        style={{marginLeft: -10, backgroundColor: PrimaryColor}}
                        onPress={() => {
                            this.props.navigation.push("Home", {
                                book: ""
                            })
                        }}
                        title="VIEW MORE"/>
                </View>
                <ScrollView
                    horizontal={true}
                >
                    {this.state.libraries.map((e) => {
                        return <LibraryCard library={e}/>
                    })}
                </ScrollView>
            </View>
        )
    }

    render() {
        return (
            <ScrollView>
                <View style={styles.topView}>
                    {BookUI.getBookProfile(this.book)}
                    <View style={{padding: 5, marginLeft: 10}}>
                        <Text
                            style={styles.textBookName}>
                            {Utility.firstToUppercase(this.book.name)}
                        </Text>
                        {this.book.isAvailable ? (
                            <Text
                                style={{marginTop: 5, color: 'green', fontWeight: 'bold'}}
                            >
                                Available
                            </Text>
                        ) : (
                            <Text
                                style={{marginTop: 5, color: '#d6d7da', fontWeight: 'bold'}}
                            >
                                Not available
                            </Text>
                        )}
                        {this.book.barcode ? (
                            <View style={{flexDirection: 'row', marginTop: 5}}>
                                <MaterialIcon name='barcode-scan' size={25}/>
                                <Text style={{marginLeft: 5, marginTop: 3}}>{this.book.barcode}</Text>
                            </View>) : <View />
                        }
                        {this.renderTags()}
                    </View>
                </View>

                <View>
                    <View style={{padding: 10}}>
                        <Text style={{fontSize: 18, fontWeight: 'bold'}}>Library information</Text>
                    </View>
                    <Divider/>
                    <View>
                        <LibraryProfileCard library={this.book.library}/>
                    </View>
                </View>

                <Divider/>
                {this.renderAtOthersLibraries()}
                {this.renderSimilarBooks()}
            </ScrollView>
        )
    }
}

const styles = StyleSheet.create({
    topView: {
        flexDirection: 'row',
        padding: 10
    },
    textBookName: {
        fontSize: 20,
        fontWeight: "bold"
    },
    tag: {
        borderWidth: 2,
        marginLeft: 3,
        padding: 4,
        borderRadius: 50,
        borderColor: "#d6d7da"
    },
    buttonTag: {
        fontSize: 10
    },
    libraryInformationTitle: {
        fontSize: 18,
        fontWeight: 'bold'
    }
});